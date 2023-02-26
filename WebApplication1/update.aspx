<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="update.aspx.cs" Inherits="WebApplication1.update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" class="">
<head runat="server">
    <title> update users </title>
    <link rel="stylesheet" href="dashbord.css" />
    <link rel="stylesheet" href="style_add.css" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />

</head>
<body>
    <div class="app-container">
  <div class="sidebar">
    <div class="sidebar-header">
      <div class="app-icon">
          <h3 id="user" runat="server"></h3>
      </div>
    </div>
    <ul class="sidebar-list">
      <li class="sidebar-list-item">
        <a href="WebForm2.aspx">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-home"><path d="M3 9l9-7 9 7v11a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2z"/><polyline points="9 22 9 12 15 12 15 22"/></svg>
          <span>Home</span>
        </a>
      </li>
      <li class="sidebar-list-item">
        <a href="add.aspx">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-shopping-bag"><path d="M6 2L3 6v14a2 2 0 0 0 2 2h14a2 2 0 0 0 2-2V6l-3-4z"/><line x1="3" y1="6" x2="21" y2="6"/><path d="M16 10a4 4 0 0 1-8 0"/></svg>
          <span> Add  </span>
        </a>
      </li>
      <li class="sidebar-list-item active">
        <a href="update.aspx">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-pie-chart"><path d="M21.21 15.89A10 10 0 1 1 8 2.83"/><path d="M22 12A10 10 0 0 0 12 2v10z"/></svg>
          <span>Update</span>
        </a>
      </li>
      <li class="sidebar-list-item">
        <a href="delete.aspx">
          <svg xmlns="http://www.w3.org/2000/svg" width="18" height="18" viewBox="0 0 24 24" fill="none" stroke="currentColor" stroke-width="2" stroke-linecap="round" stroke-linejoin="round" class="feather feather-inbox"><polyline points="22 12 16 12 14 15 10 15 8 12 2 12"/><path d="M5.45 5.11L2 12v6a2 2 0 0 0 2 2h16a2 2 0 0 0 2-2v-6l-3.45-6.89A2 2 0 0 0 16.76 4H7.24a2 2 0 0 0-1.79 1.11z"/></svg>
          <span>Delete</span>
        </a>
      </li>
     
    </ul>
   
  </div>
  <div class="app-content">
      <button class="mode-switch" title="Switch Theme">
        <svg class="moon" fill="none" stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" width="24" height="24" viewBox="0 0 24 24">
          <defs></defs>
          <path d="M21 12.79A9 9 0 1111.21 3 7 7 0 0021 12.79z"></path>
        </svg>
      </button>
    <div class="app-content-header">
      <h1 class="app-content-headerText"> Students  </h1>
    
    </div>
    <div class="app-content-actions">
    </div>
          <div class="products-area-wrapper tableView">

    <form id="form" action="data.aspx" method="get" runat="server">
        <br />
        <div class="div-form">
            <div class="custom-select">
                     <select name='id'>

                       <main id="select_id" runat="server">

                       </main>
                        </select>

          
            </div>        
       
          
<br />
            <input placeholder="NAME  : " name="name" type="text"  />
<br />

            <input placeholder="LEVEL : " name="level" type="text"  />
<br />

            <input placeholder="GPA    : " name="gpa" type="text"  />
<br />

            <button name="send" id="send" value="update" type="submit" runat="server"> update </button>


        </div>
    </form>
              </div>
      </div>

        <script src="script.js"></script>
</body>
</html>
