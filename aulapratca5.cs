using system;
using system.IO;

class program
{
    static void main()
    {
        console.writeline("Digite o caminho de uma pasta (ex: C:\\windows\\web ou. para de atual):");
        string caminhoinicial=console.readline();

        if(caminhoinicial==".") caminhoinicial=directory.getcurrentdirectory();

        try
        {
            console.writeline($"\nexplorando:{caminhoinicial}\n");
            explorardiretorios(caminhoinicial,0);
        }
        catch(exception ex)
        {
            console.writeline("Erro ao acessar pasta:" + ex.message);
        }
    }

    static void explorardiretorios(string caminho, int nivel)
    {
        try
        {
            string indentacao=new string('-', nivel*2);

            string arquivos=directory.getfiles(caminho);

            foreach (string arquivos in arquivos)
            {
                console.writeline($"{intentacao} {path.getfilename(arquivo)}");
            }

            string subdiretorios=directory.getdirectories(caminho);
            foreach (string dir in subdiretorios)
            {
                console.writeline($"{indentacao} [{path.getfilename(dir)}]");

                explorardiretorios(dir, nivel + 1);
            }
        }

        catch(unauthorizedacessexception)
        {
            
        }
    }
}
