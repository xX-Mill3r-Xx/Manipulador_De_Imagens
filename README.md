# Manipulador De Imagens
Um repositório para meus estudos sobre manipulação de imagens em CSharp e Windows Forms
-----
# Projeto 001
-----

# 📁 Anexo de Ordem de Serviço (Windows Forms)

Este projeto é uma aplicação de exemplo desenvolvida em **C\#** utilizando **Windows Forms** que demonstra a funcionalidade de **seleção, visualização e persistência de anexos (imagens) em um banco de dados SQL Server**. Ideal para integrar a sistemas de gerenciamento de ordens de serviço (OS) ou qualquer aplicação que necessite de gerenciamento de arquivos visuais.

-----

## 🚀 Funcionalidades Principais

  * **Seleção Múltipla de Imagens**: Permite ao usuário selecionar uma ou múltiplas imagens (JPG, PNG, JPEG) de uma só vez através de uma caixa de diálogo `OpenFileDialog`.
  * **Exibição Dinâmica de Anexos**: As imagens selecionadas são exibidas dinamicamente em um `FlowLayoutPanel`, cada uma com sua pré-visualização em `PictureBox` e um campo de texto (`TextBox`) para descrição.
  * **Gerenciamento de Anexos Individuais**: Para cada anexo exibido, são disponibilizados botões para:
      * **Download**: Salvar a imagem em uma localização específica no computador do usuário.
      * **Excluir**: Remover o anexo da lista de exibição.
      * **Visualizar**: Abrir uma janela de visualização em tamanho maior (funcionalidade comentada, mas preparada para implementação).
  * **Persistência em Banco de Dados**: A aplicação é capaz de salvar todos os anexos exibidos em um banco de dados SQL Server, relacionando-os a uma Ordem de Serviço (OS) existente. As imagens são armazenadas como dados binários (`byte[]`).
  * **Validação de Chave Estrangeira**: Demonstra o uso e tratamento de erros de Foreign Key, garantindo que os anexos só sejam salvos se estiverem vinculados a uma Ordem de Serviço válida e já existente no banco.

-----

## 💻 Tecnologias Utilizadas

  * **Linguagem**: C\#
  * **Plataforma**: .NET Framework (Windows Forms)
  * **Banco de Dados**: SQL Server
  * **ORM / Micro-ORM**: [Dapper](https://github.com/DapperLib/Dapper) - Leve e rápido, utilizado para operações de acesso a dados.
  * **Controles UI**: `FlowLayoutPanel`, `PictureBox`, `Button`, `TextBox`, `OpenFileDialog`, `SaveFileDialog`, `ToolTip`, `Label`.

-----

## 🛠️ Como o Projeto Está Estruturado

O projeto foi organizado para promover a modularidade e a separação de responsabilidades:

  * **`InserirAnexo.Funcoes`**: Contém a lógica de interface do usuário, responsável pela criação dinâmica dos controles (botões, picture boxes, textboxes) e suas interações visuais.
  * **`InserirAnexo.Models`**: Define o modelo de dados `OSD_ordem_servico_anexo`, que representa a estrutura do anexo a ser persistida no banco de dados.
  * **`InserirAnexo.ServiceContracts`**: Define a interface `IOSD_ordem_servico_anexo`, estabelecendo o contrato para as operações de serviço (como inserir, atualizar, etc.).
  * **`InserirAnexo.Services`**: Implementa a lógica de persistência de dados, utilizando Dapper para interagir com o SQL Server.
  * **`InserirAnexo.UI`**: Contém o formulário principal (`FrmInserirAnexos`) onde a interface do usuário é montada e as funcionalidades são orquestradas.
  * **`InserirAnexo.Conexao`**: (Não diretamente no código fornecido, mas inferido) Presume-se que haja uma classe ou método para fornecer a string de conexão com o banco de dados.

-----

## 🚀 Como Executar o Projeto (Configuração)

Para rodar este projeto em sua máquina, siga os passos abaixo:

1.  **Clone o Repositório**:

    ```bash
    git clone https://github.com/SeuUsuario/NomeDoSeuRepositorio.git
    cd NomeDoSeuRepositorio
    ```

2.  **Configurar o Banco de Dados SQL Server**:

      * Crie um banco de dados (ex: `Imagens`).
      * Crie a tabela `OSD_ordem_servico` (mesmo que seja apenas com `ods_codtemp` como chave primária, se você não tiver uma tabela completa de ordens de serviço).
        ```sql
        CREATE TABLE OSD_ordem_servico (
            ods_codtemp BIGINT PRIMARY KEY IDENTITY(1,1),
            -- Outras colunas da sua ordem de serviço
            ods_data DATETIME DEFAULT GETDATE()
        );
        ```
      * Crie a tabela `OSD_ordem_servico_anexo`:
        ```sql
        CREATE TABLE OSD_ordem_servico_anexo (
            oax_codtemp BIGINT PRIMARY KEY IDENTITY(1,1),
            oax_codserv BIGINT NOT NULL, -- Este campo se refere ao ID da OS, nome mantido do código
            ods_codtemp BIGINT NOT NULL, -- Chave estrangeira para OSD_ordem_servico
            oax_data DATETIME DEFAULT GETDATE(),
            oax_descricao VARCHAR(255) NULL,
            oax_imagem VARBINARY(MAX) NOT NULL,
            oax_extensao VARCHAR(10) NULL,
            CONSTRAINT FK_OSD_ordem_servico_anexo_OSD_ordem_servico
                FOREIGN KEY (ods_codtemp) REFERENCES OSD_ordem_servico (ods_codtemp)
        );
        ```
      * **Insira uma Ordem de Serviço de teste**: Para poder testar a funcionalidade de salvar anexos, você precisará ter pelo menos uma Ordem de Serviço cadastrada em `OSD_ordem_servico`. Anote o `ods_codtemp` gerado.
        ```sql
        INSERT INTO OSD_ordem_servico (ods_data) VALUES (GETDATE());
        -- Ou com outras colunas se sua tabela tiver mais campos
        ```

3.  **Atualize a String de Conexão**:

      * No arquivo `FrmInserirAnexos.cs` ou na sua classe `StringConection.Conexao()`, atualize a string de conexão para apontar para o seu banco de dados SQL Server.
      * **Exemplo de string de conexão (no `FrmInserirAnexos.cs`):**
        ```csharp
        // private readonly IOSD_ordem_servico_anexo<OSD_ordem_servico_anexo> _anexoIService;
        // private const string ConnectionString = "Data Source=SEU_SERVIDOR;Initial Catalog=Imagens;Integrated Security=True;"; // Ou com usuário/senha
        // ...
        // _anexoIService = new OSD_ordem_servico_anexoService(ConnectionString);
        ```
        Certifique-se de substituir `SEU_SERVIDOR` pelo nome do seu servidor SQL Server.

4.  **Atualize o ID da Ordem de Serviço no Código**:

      * No método `btnSalvarAnexos_Click` do seu `FrmInserirAnexos.cs`, altere `ods_codtemp = 123;` para o **valor real do `ods_codtemp` da Ordem de Serviço de teste** que você inseriu no passo 2.

    <!-- end list -->

    ```csharp
    private async void btnSalvarAnexos_Click(object sender, EventArgs e)
    {
        long ods_codtemp_real = SEU_ID_DA_ORDEM_DE_SERVICO_EXISTENTE; // <-- SUBSTITUA AQUI!
        long codTemporario = DateTime.Now.Ticks; // Pode ser um valor qualquer para o ID temporário do anexo

        await Funcoes.FuncaoAnexo.SalvarTodosAnexosNobanco(flpPrincipalAnexos, lbInformacoes, _anexoIService, ods_codtemp_real, codTemporario);
    }
    ```

5.  **Restaurar Imagens de Recurso**:

      * Certifique-se de que as imagens `Download.png`, `Lixeira.png` e `Visualizar.png` estejam presentes na pasta `Properties/Resources` do seu projeto ou em um local acessível para que os botões sejam renderizados corretamente.

6.  **Compilar e Executar**: Abra a solução no Visual Studio e execute o projeto.

-----

## 🤝 Contribuições

Sinta-se à vontade para explorar, testar e contribuir com este projeto\! Seja para aprimorar funcionalidades, refatorar o código ou corrigir bugs, toda contribuição é bem-vinda.

-----

## 📄 Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo `LICENSE` para mais detalhes. (Se você não tiver um, pode criar um arquivo `LICENSE` com o texto da licença MIT).

-----
