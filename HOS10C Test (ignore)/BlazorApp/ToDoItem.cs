/*declares & initializes new public class called in ToDo.razor*/
public class ToDoItem
{
    /*used to capture user input value (newToDo) as part of the HTML display coding 
    when creating the user's To Do list*/
    public string Title { get; set; }
    public bool IsDone { get; set; }
}