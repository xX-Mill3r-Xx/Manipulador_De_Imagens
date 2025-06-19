namespace InserirAnexo.Conexao
{
    public static class StringConection
    {
        public static string Conexao()
        {
            string conexao = @"Server=[ seu servidor ];Database=[ sua base de dados ];Trusted_Connection=True;";
            return conexao;
        }
    }
}
