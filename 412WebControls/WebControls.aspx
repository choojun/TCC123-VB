<%@ Page Language="VB" AutoEventWireup="false" CodeFile="WebControls.aspx.vb" Inherits="WebControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Web Controls Demonstration</title>
    <style type="text/css">
       .style1             
       {                   
          width: 230px;    
          height: 21px;    
       }                   
       .style2             
       {                   
          width: 231px;    
          height: 21px;    
       }                   
    </style>               
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h3>This is the WOU enrollment form.</h3>
      <p>
         <em>Please fill in all fields and click Register.</em></p>
      <p>
          &nbsp;
         <span style="color: teal">                                       
            1.                                       
            Please fill out the fields below.</span>                      
      </p>
      <table id="TABLE1">
         <tr>
            <td valign="top" class="style1">
               <asp:Image ID="firstNameImage" runat="server" 
                  EnableViewState="False" ImageUrl="~/Images/fname.png" />
               <asp:TextBox ID="firstNameTextBox" runat="server"
                  EnableViewState="False"></asp:TextBox>        
            </td>
            <td valign="top" class="style1">
               <asp:Image ID="lastNameImage" runat="server" 
                  EnableViewState="False" ImageUrl="~/Images/lname.png" />
               <asp:TextBox ID="lastNameTextBox" runat="server" 
                  EnableViewState="False"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td style="width: 230px" valign="top">
               <asp:Image ID="emailImage" runat="server" 
                  EnableViewState="False" ImageUrl="~/Images/email.png" />
               <asp:TextBox ID="emailTextBox" runat="server" 
                  EnableViewState="False"></asp:TextBox>
            </td>
            <td style="width: 231px" valign="top">
               <asp:Image ID="phoneImage" runat="server" 
                  EnableViewState="False" ImageUrl="~/Images/phone.png" />
               <asp:TextBox ID="phoneTextBox" runat="server" 
                  EnableViewState="False"></asp:TextBox>
               Must be in the form (555) 555-5555.
            </td>
         </tr>
      </table>
      <p>
          &nbsp; 
         <span style="color: teal">
            2.
            Which programme would you like information about?</span>
      </p>
      <p>
         <asp:DropDownList ID="booksDropDownList" runat="server"         
            EnableViewState="False">       
             <asp:ListItem>Bachelor of Software Engineering (Hons)</asp:ListItem>
            <asp:ListItem>Bachelor of Information Technology (Hons) in Networking</asp:ListItem>                              
             <asp:ListItem>Bachelor of Information Technology (Hons) in Multimedia Systems</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Mechatronics</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Telecommunications</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Information Systems</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Construction Management</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Electronics</asp:ListItem>
             <asp:ListItem>Bachelor of Technology (Hons) in Computer Systems and Networks</asp:ListItem>
             <asp:ListItem>Master of Business Administration in Construction Management</asp:ListItem>
             <asp:ListItem>Master of Business Administration in Manufacturing and Production Management</asp:ListItem>
         </asp:DropDownList>                                             
      </p>
      <p>
         <asp:HyperLink ID="booksHyperLink" runat="server"             
            EnableViewState="False" NavigateUrl="http://www.wou.edu.my/school-of-science-and-technology/"
            Target="_blank">                                           
            Click here to view more information about our programme        
         </asp:HyperLink>                                              
      </p>
      <p>
         &nbsp;<span style="color: teal">3.
            Which operating system are you using?</span>
      </p>
      <p>
         <asp:RadioButtonList ID="operatingSystemRadioButtonList"
            runat="server" EnableViewState="False">              
            <asp:ListItem>Windows Vista</asp:ListItem>           
            <asp:ListItem>Windows XP</asp:ListItem>     
            <asp:ListItem>Windows 7</asp:ListItem>    
            <asp:ListItem>Windows 10</asp:ListItem>           
            <asp:ListItem>Mac OS X</asp:ListItem>                
            <asp:ListItem>Linux</asp:ListItem>                   
            <asp:ListItem>Other</asp:ListItem>                   
         </asp:RadioButtonList>                                  
      </p>
      <p>
         <asp:Button ID="registerButton" runat="server"
            EnableViewState="False" Text="Register" /> 
      </p>
   </div>
   </form>
</body>
</html>
