// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "c:\Users\Saman\Desktop\CS 504\3. Hands On Skills\CS504-Summer-2021-HOS---Hipples\Module 10\BlazorApp\Pages\ToDo.razor"
       

/*declares new list based on public class ToDoItem*/
    private IList<ToDoItem> todos = new List<ToDoItem>();
/*declares newToDo as private string variable*/        
    private string newToDo;
/*declares AddToDo() method using binded newToDo variable that is initialized by user input;
upon submission, user input is added to a To Do list displayed on screen*/
    private void AddToDo()
    {
        if (!string.IsNullOrWhiteSpace(newToDo))
        {
            todos.Add(new ToDoItem { Title = newToDo });
            newToDo = string.Empty; /*resets user input space to allow more than one entry*/
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
