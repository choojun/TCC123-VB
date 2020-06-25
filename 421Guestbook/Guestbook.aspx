<%-- Guestbook Web application with a form for users to submit --%>
<%-- guestbook entires and a GridView to view existing entries. --%>
<%@ Page Language="VB" AutoEventWireup="false" 
   CodeFile="Guestbook.aspx.vb" Inherits="Guestbook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
   <title>Guestbook</title>
   <style type="text/css">
      .style1
      {
         width: 100%
      }
      .style2
      {
         width: 130px
      }
   </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h2>
         Please leave a message in our guestbook:</h2>
      <table class="style1">
         <tr>
            <td class="style2" valign="top">
               Your name:<br />
            </td>
            <td valign="top">
               <asp:TextBox ID="nameTextBox" runat="server" 
                  Width="300px"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2" valign="top">
               Your e-mail address:<br />
            </td>
            <td valign="top">
               <asp:TextBox ID="emailTextBox" runat="server" 
                  Width="300px"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2" valign="top">
               Tell the world:<br />
            </td>
            <td valign="top">
               <asp:TextBox ID="messageTextBox" runat="server" Rows="8"
                  Height="100px" Width="300px" TextMode="MultiLine">
               </asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2" valign="top">
            </td>
            <td valign="top">
               <asp:Button ID="submitButton" runat="server" 
                  Text="Submit" />
               <asp:Button ID="clearButton" runat="server" 
                  Text="Clear" />
            </td>
         </tr>
      </table>
      <br />
      <asp:GridView ID="messagesGridView" runat="server"
         AutoGenerateColumns="False" CellPadding="4"
         DataKeyNames="MessageID" DataSourceID="messagesLinqDataSource"
         ForeColor="#333333" GridLines="None" Width="600px">
         <FooterStyle BackColor="#1C5E55" Font-Bold="True" 
            ForeColor="White" />
         <Columns>                                                  
            <asp:BoundField DataField="Date" HeaderText="Date"      
               SortExpression="Date" />                             
            <asp:BoundField DataField="Name" HeaderText="Name"      
               SortExpression="Name" />                             
            <asp:BoundField DataField="Email" HeaderText="Email"    
               SortExpression="Email" />                            
            <asp:BoundField DataField="Message" HeaderText="Message"
               SortExpression="Message" />                          
         </Columns>                                                 
         <RowStyle BackColor="#E3EAEB" />
         <EditRowStyle BackColor="#7C6F57" />
         <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" 
            ForeColor="#333333" />
         <PagerStyle BackColor="#666666" ForeColor="White" 
            HorizontalAlign="Center" />
         <HeaderStyle BackColor="#1C5E55" Font-Bold="True" 
            ForeColor="White" />
         <AlternatingRowStyle BackColor="White" />
      </asp:GridView>
      <asp:LinqDataSource ID="messagesLinqDataSource" runat="server" 
         ContextTypeName="GuestbookDBDataContext" EnableInsert="True"
         TableName="Messages" EnableDelete="True" EnableUpdate="True">                                       
      </asp:LinqDataSource>                                          
   </div>
   </form>
</body>
</html>
