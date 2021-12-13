using E_JOGOS.Interface;

namespace E_JOGOS.Models
{
    //Herança em C#: em vez de extends, usa-se :
    //Uso de interface em C#: em vez de implements, usa-se ,
    public class Equipe : EjogosBase, IEquipe
    {
        //Construtor => função que inicia quando da instanciação
        //da classe
        private const string path = "Database/equipe.csv";
        public Equipe()
        {
            CreateFolderAndFile(path);
        }
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //Função que irá converter de estring p/ Equipe
        private string Prepare(Equipe e)
        {
            return $"{e.IdEquipe};{e.Nome};{e.Imagem}";
        }
        public void Create(Equipe nova_equipe)
        {
            //recebe um objeto de Equipe e grava no .csv
            string[] linha = {Prepare(nova_equipe)};
            File.AppendAllLines(path, linha);
        }

        public void Delete(int idEquipe)
        {
            throw new NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new List<Equipe> ();
            string[] linhas = File.ReadAllLines(path);

            foreach(string linha in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(linha.Split(';')[0]);
                equipe.Nome = linha.Split(';')[1];
                equipe.Imagem = linha.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;
        }

        public void Update(Equipe equipe)
        {
            throw new NotImplementedException();
        }
    }
}
