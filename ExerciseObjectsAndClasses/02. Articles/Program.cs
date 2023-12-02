//логиката на въвейдане и принтиране
string articleData = Console.ReadLine();

string title = articleData.Split(", ")[0];
string content = articleData.Split(", ")[1];
string author = articleData.Split(", ")[2];

Article article = new Article(title, content, author); //article will be working with, creating the object 

int countCommand = int.Parse(Console.ReadLine());  

for(int i = 1; i <= countCommand; i++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(": ");
    string commandName = commandParts[0];
    string commandParameter = commandParts[1];
    switch (commandName)
    {
        case "Edit":
            //change the content
            article.Edit(commandParameter);
            break;
        case "ChangeAuthor":
            //change the author
            article.ChangeAuthor(commandParameter);
            break;
        case "Rename":
            //change title
            article.Rename(commandParameter);
            break;
    }
}
//print the article
Console.WriteLine(article.ToString());

 
