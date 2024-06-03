using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using Satuk.output;

namespace Satuk
{
    class Program
    {
        internal static void Main()
        {
            try
            {
                var dllDir = AppDomain.CurrentDomain.BaseDirectory;
                var projectDirectory = Directory.GetParent(dllDir)?.Parent?.Parent?.Parent?.FullName ??
                                       throw new IOException("path is null");
                var input = new AntlrFileStream(Path.Combine(projectDirectory, "test1.Satuk"));
                var lexer = new SatukLexer(input);
                var tokens = new CommonTokenStream(lexer);
                var parser = new SatukParser(tokens);
                IParseTree tree = parser.program();

                var visitor = new Visitor();
                visitor.Visit(tree);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}