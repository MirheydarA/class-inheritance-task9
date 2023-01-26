namespace test;
internal class Program
{
    static void Main()
    {
        Keyword: var keyword = Console.ReadLine();

        switch(keyword.ToLower())
        {
            case "basic":
                var documentprogram = new DocumentProgram();
                documentprogram.OpenDocument();
                documentprogram.EditDocument();
                documentprogram.SaveDocument();
                break;
            case "pro":
                var prodocumentprogram = new ProDocumentProgram();
                prodocumentprogram.OpenDocument();
                prodocumentprogram.EditDocument();
                prodocumentprogram.SaveDocument();
                break;
            case "expert":
                var expertdocumentprogram = new ExpertDocumentProgram();
                expertdocumentprogram.OpenDocument();
                expertdocumentprogram.EditDocument();
                expertdocumentprogram.SaveDocument();
                break;
                default:
                goto Keyword;


        }
        
        
          
        
            
            

       
        
        
        
        
        
    }
}
