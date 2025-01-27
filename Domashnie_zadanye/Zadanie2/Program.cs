namespace Zadanie2
{
    public abstract class Translator
    {
        public abstract string GetLanguage();
    }
    class EnglishTranslator : Translator
    {
        public override string GetLanguage()
        {
            return "Я перевеодчик с английского";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EnglishTranslator Translator = new EnglishTranslator();
            Console.WriteLine(Translator.GetLanguage());
        }
    }
}
