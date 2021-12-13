using E_JOGOS.Models;

namespace E_JOGOS.Interface
{
    /*
     RESPONSÁVEL POR DETERMINAR QUAIS MÉTODOS UMA CLASSE TERÁ DE
    ACORDO COM UMA SOBRESCRIÇÃO
     */
    public interface IEquipe
    {
        //CREATE
        void Create(Equipe nova_equipe);

        //READALL
        List<Equipe> ReadAll();

        //UPDATE
        void Update(Equipe equipe);

        //DELETE
        void Delete(int idEquipe);
    }
}
