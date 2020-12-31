<%-- Fig. 21.67: Validation.aspx --%>
<%-- Validation application enchanced by ASP.NET Ajax. --%>
<%@ Page Language="VB" AutoEventWireup="false" 
   CodeFile="Validation.aspx.vb" Inherits="Validation" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" 
   TagPrefix="ajax" %>                                                   

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Demonstrating Validation Controls</title>
    <style type="text/css">
       .style1
       {
          width: 100%;
       }
    </style>
</head>
<body>
<form id="form1" runat="server">
<div>
   <ajax:ToolkitScriptManager ID="ToolkitScriptManager1"
      runat="server">                                   
   </ajax:ToolkitScriptManager>                         
   Please fill out the following form.<br /><em>All fields are required
   and must contain valid information</em><br /><br />
   <ajax:TabContainer ID="TabContainer1" runat="server"              
      ActiveTabIndex="0" Width="450px">                              
      <ajax:TabPanel runat="server" HeaderText="Name" ID="TabPanel1">
         <ContentTemplate>                                           
         <table class="style1">
            <tr>
               <td align="right">First Name:</td>
               <td>
                  <asp:TextBox ID="firstNameTextBox" runat="server">
                  </asp:TextBox>
                  <asp:RequiredFieldValidator 
                     ID="firstNameInputValidator" runat="server" 
                     ControlToValidate="firstNameTextBox" Display="None" 
                     ErrorMessage="Please enter your first name.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender               
                     ID="firstNameInputCallout" runat="server" 
                     Enabled="True"                            
                     TargetControlID="firstNameInputValidator">
                  </ajax:ValidatorCalloutExtender>             
               </td>
            </tr>
            <tr>
               <td align="right">Last Name:</td>
               <td>
                  <asp:TextBox ID="lastNameTextBox" runat="server">
                  </asp:TextBox>
                  <asp:RequiredFieldValidator ID="lastNameInputValidator"
                     runat="server" ControlToValidate="lastNameTextBox" 
                     Display="None" 
                     ErrorMessage="Please enter your last name.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender              
                     ID="lastNameInputCallout" runat="server" 
                     Enabled="True"                           
                     TargetControlID="lastNameInputValidator">
                  </ajax:ValidatorCalloutExtender>            
               </td>
            </tr>
         </table>
         </ContentTemplate>                                             
      </ajax:TabPanel>                                                  
      <ajax:TabPanel ID="TabPanel2" runat="server" HeaderText="Contact">
         <ContentTemplate>                                              
         <table class="style1">
            <tr>
               <td align="right">E-mail address:</td>
               <td>
                  <asp:TextBox ID="emailTextBox" runat="server">
                  </asp:TextBox>
                  e.g., user@domain.com
                  <asp:RequiredFieldValidator ID="emailInputValidator" 
                     runat="server" ControlToValidate="emailTextBox"
                     Display="None" 
                     ErrorMessage="Please enter your e-mail address.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender ID="emailInputCallout"
                     runat="server" Enabled="True"                     
                     TargetControlID="emailInputValidator">            
                  </ajax:ValidatorCalloutExtender>                     
                  <asp:RegularExpressionValidator 
                     ID="emailFormatValidator" runat="server" 
                     ControlToValidate="emailTextBox" Display="None"
                     ErrorMessage="Please enter a valid e-mail address." 
                     ValidationExpression=
                        "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                  </asp:RegularExpressionValidator>
                  <ajax:ValidatorCalloutExtender ID="emailFormatCallout"
                     runat="server" Enabled="True"                      
                     TargetControlID="emailFormatValidator">            
                  </ajax:ValidatorCalloutExtender>                      
               </td>
            </tr>
            <tr>
               <td align="right">Phone number:</td>
               <td>
                  <asp:TextBox ID="phoneTextBox" runat="server">
                  </asp:TextBox>
                  e.g., (555) 555-1234
                  <asp:RequiredFieldValidator ID="phoneInputValidator"
                     runat="server" ControlToValidate="phoneTextBox" 
                     Display="None" 
                     ErrorMessage="Please enter your phone number.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender ID="phoneInputCallout"
                     runat="server" Enabled="True"                     
                     TargetControlID="phoneInputValidator">            
                  </ajax:ValidatorCalloutExtender>                     
                  <asp:RegularExpressionValidator 
                     ID="phoneFormatValidator" runat="server"
                     ControlToValidate="phoneTextBox" Display="None" 
                     ErrorMessage="Please enter a valid phone number." 
                     ValidationExpression=
                        "((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
                  </asp:RegularExpressionValidator>
                  <ajax:ValidatorCalloutExtender ID="phoneFormatCallout"
                     runat="server" Enabled="True"                      
                     TargetControlID="phoneFormatValidator">            
                  </ajax:ValidatorCalloutExtender>                      
               </td>
            </tr>
         </table>
         </ContentTemplate>
      </ajax:TabPanel>     
   </ajax:TabContainer>    
   <br />
   <asp:Button ID="submitButton" runat="server" Text="Submit" />
   <br /><br />
   <asp:UpdatePanel ID="outputUpdatePanel" runat="server">
      <ContentTemplate>                                   
         <asp:Label ID="outputLabel" Visible="false" runat="server" 
            Text="Thank you for your submission.">
         </asp:Label>
      </ContentTemplate>                                   
      <Triggers>                                           
         <asp:AsyncPostBackTrigger ControlID="submitButton"
            EventName="Click">                             
         </asp:AsyncPostBackTrigger>                       
      </Triggers>                                          
   </asp:UpdatePanel>                                      
</div>
</form>
</body>
</html>

<%-- 
 ************************************************************************** 
 * (C) Copyright 1992-2006 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 **************************************************************************
--%>