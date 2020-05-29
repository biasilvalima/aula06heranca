namespace aula06heranca
{
    // Classe PAI.
    public class pessoa
    {
        public string nome;

    /// <summary>
    /// Saudação
    /// </summary>
    /// <returns>Saudação + nome da pessoa</returns>
        public string Saudar(){
            return "Seja bem vindo (a)"+nome;
        }
    }
}