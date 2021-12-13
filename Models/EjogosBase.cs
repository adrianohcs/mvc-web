namespace E_JOGOS.Models
{
    public class EjogosBase
    {
        //Função para criar a pasta e o arquivo

        //string path é o parâmetro da função que terá o caminho
        //para a análise da função.
        public void CreateFolderAndFile(string path)
        {
            // pasta/arquivo.csv
            string folder = path.Split('/')[0]; //recebe o nome da pasta
            string file = path.Split('/')[1]; //recebe o nome do arquivo


            //caso não exista, cria a pasta
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            //se não existir arquivo na pasta, ele é criado
            if (!File.Exists(file))
            {
                File.Create(path);
            }

        }
    }
}
