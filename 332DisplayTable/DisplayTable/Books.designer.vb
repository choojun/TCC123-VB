﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Books")>  _
Partial Public Class BooksDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAuthorISBN(instance As AuthorISBN)
    End Sub
  Partial Private Sub UpdateAuthorISBN(instance As AuthorISBN)
    End Sub
  Partial Private Sub DeleteAuthorISBN(instance As AuthorISBN)
    End Sub
  Partial Private Sub InsertAuthor(instance As Author)
    End Sub
  Partial Private Sub UpdateAuthor(instance As Author)
    End Sub
  Partial Private Sub DeleteAuthor(instance As Author)
    End Sub
  Partial Private Sub InsertTitle(instance As Title)
    End Sub
  Partial Private Sub UpdateTitle(instance As Title)
    End Sub
  Partial Private Sub DeleteTitle(instance As Title)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.DisplayTable.MySettings.Default.BooksConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property AuthorISBNs() As System.Data.Linq.Table(Of AuthorISBN)
		Get
			Return Me.GetTable(Of AuthorISBN)
		End Get
	End Property
	
	Public ReadOnly Property Authors() As System.Data.Linq.Table(Of Author)
		Get
			Return Me.GetTable(Of Author)
		End Get
	End Property
	
	Public ReadOnly Property Titles() As System.Data.Linq.Table(Of Title)
		Get
			Return Me.GetTable(Of Title)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.AuthorISBN")>  _
Partial Public Class AuthorISBN
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _AuthorID As Integer
	
	Private _ISBN As String
	
	Private _Author As EntityRef(Of Author)
	
	Private _Title As EntityRef(Of Title)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnAuthorIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAuthorIDChanged()
    End Sub
    Partial Private Sub OnISBNChanging(value As String)
    End Sub
    Partial Private Sub OnISBNChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Author = CType(Nothing, EntityRef(Of Author))
		Me._Title = CType(Nothing, EntityRef(Of Title))
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AuthorID", DbType:="Int NOT NULL", IsPrimaryKey:=true)>  _
	Public Property AuthorID() As Integer
		Get
			Return Me._AuthorID
		End Get
		Set
			If ((Me._AuthorID = value)  _
						= false) Then
				If Me._Author.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnAuthorIDChanging(value)
				Me.SendPropertyChanging
				Me._AuthorID = value
				Me.SendPropertyChanged("AuthorID")
				Me.OnAuthorIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ISBN", DbType:="VarChar(20) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property ISBN() As String
		Get
			Return Me._ISBN
		End Get
		Set
			If (String.Equals(Me._ISBN, value) = false) Then
				If Me._Title.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
				End If
				Me.OnISBNChanging(value)
				Me.SendPropertyChanging
				Me._ISBN = value
				Me.SendPropertyChanged("ISBN")
				Me.OnISBNChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Author_AuthorISBN", Storage:="_Author", ThisKey:="AuthorID", OtherKey:="AuthorID", IsForeignKey:=true)>  _
	Public Property Author() As Author
		Get
			Return Me._Author.Entity
		End Get
		Set
			Dim previousValue As Author = Me._Author.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Author.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Author.Entity = Nothing
					previousValue.AuthorISBNs.Remove(Me)
				End If
				Me._Author.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.AuthorISBNs.Add(Me)
					Me._AuthorID = value.AuthorID
				Else
					Me._AuthorID = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Author")
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Title_AuthorISBN", Storage:="_Title", ThisKey:="ISBN", OtherKey:="ISBN", IsForeignKey:=true)>  _
	Public Property Title() As Title
		Get
			Return Me._Title.Entity
		End Get
		Set
			Dim previousValue As Title = Me._Title.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Title.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Title.Entity = Nothing
					previousValue.AuthorISBNs.Remove(Me)
				End If
				Me._Title.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.AuthorISBNs.Add(Me)
					Me._ISBN = value.ISBN
				Else
					Me._ISBN = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Title")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Authors")>  _
Partial Public Class Author
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _AuthorID As Integer
	
	Private _FirstName As String
	
	Private _LastName As String
	
	Private _AuthorISBNs As EntitySet(Of AuthorISBN)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnAuthorIDChanging(value As Integer)
    End Sub
    Partial Private Sub OnAuthorIDChanged()
    End Sub
    Partial Private Sub OnFirstNameChanging(value As String)
    End Sub
    Partial Private Sub OnFirstNameChanged()
    End Sub
    Partial Private Sub OnLastNameChanging(value As String)
    End Sub
    Partial Private Sub OnLastNameChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._AuthorISBNs = New EntitySet(Of AuthorISBN)(AddressOf Me.attach_AuthorISBNs, AddressOf Me.detach_AuthorISBNs)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_AuthorID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property AuthorID() As Integer
		Get
			Return Me._AuthorID
		End Get
		Set
			If ((Me._AuthorID = value)  _
						= false) Then
				Me.OnAuthorIDChanging(value)
				Me.SendPropertyChanging
				Me._AuthorID = value
				Me.SendPropertyChanged("AuthorID")
				Me.OnAuthorIDChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstName", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property FirstName() As String
		Get
			Return Me._FirstName
		End Get
		Set
			If (String.Equals(Me._FirstName, value) = false) Then
				Me.OnFirstNameChanging(value)
				Me.SendPropertyChanging
				Me._FirstName = value
				Me.SendPropertyChanged("FirstName")
				Me.OnFirstNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastName", DbType:="VarChar(30) NOT NULL", CanBeNull:=false)>  _
	Public Property LastName() As String
		Get
			Return Me._LastName
		End Get
		Set
			If (String.Equals(Me._LastName, value) = false) Then
				Me.OnLastNameChanging(value)
				Me.SendPropertyChanging
				Me._LastName = value
				Me.SendPropertyChanged("LastName")
				Me.OnLastNameChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Author_AuthorISBN", Storage:="_AuthorISBNs", ThisKey:="AuthorID", OtherKey:="AuthorID")>  _
	Public Property AuthorISBNs() As EntitySet(Of AuthorISBN)
		Get
			Return Me._AuthorISBNs
		End Get
		Set
			Me._AuthorISBNs.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_AuthorISBNs(ByVal entity As AuthorISBN)
		Me.SendPropertyChanging
		entity.Author = Me
	End Sub
	
	Private Sub detach_AuthorISBNs(ByVal entity As AuthorISBN)
		Me.SendPropertyChanging
		entity.Author = Nothing
	End Sub
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Titles")>  _
Partial Public Class Title
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ISBN As String
	
	Private _Title As String
	
	Private _EditionNumber As Integer
	
	Private _Copyright As String
	
	Private _AuthorISBNs As EntitySet(Of AuthorISBN)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnISBNChanging(value As String)
    End Sub
    Partial Private Sub OnISBNChanged()
    End Sub
    Partial Private Sub OnTitleChanging(value As String)
    End Sub
    Partial Private Sub OnTitleChanged()
    End Sub
    Partial Private Sub OnEditionNumberChanging(value As Integer)
    End Sub
    Partial Private Sub OnEditionNumberChanged()
    End Sub
    Partial Private Sub OnCopyrightChanging(value As String)
    End Sub
    Partial Private Sub OnCopyrightChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._AuthorISBNs = New EntitySet(Of AuthorISBN)(AddressOf Me.attach_AuthorISBNs, AddressOf Me.detach_AuthorISBNs)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ISBN", DbType:="VarChar(20) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property ISBN() As String
		Get
			Return Me._ISBN
		End Get
		Set
			If (String.Equals(Me._ISBN, value) = false) Then
				Me.OnISBNChanging(value)
				Me.SendPropertyChanging
				Me._ISBN = value
				Me.SendPropertyChanged("ISBN")
				Me.OnISBNChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="VarChar(100) NOT NULL", CanBeNull:=false)>  _
	Public Property Title() As String
		Get
			Return Me._Title
		End Get
		Set
			If (String.Equals(Me._Title, value) = false) Then
				Me.OnTitleChanging(value)
				Me.SendPropertyChanging
				Me._Title = value
				Me.SendPropertyChanged("Title")
				Me.OnTitleChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EditionNumber", DbType:="Int NOT NULL")>  _
	Public Property EditionNumber() As Integer
		Get
			Return Me._EditionNumber
		End Get
		Set
			If ((Me._EditionNumber = value)  _
						= false) Then
				Me.OnEditionNumberChanging(value)
				Me.SendPropertyChanging
				Me._EditionNumber = value
				Me.SendPropertyChanged("EditionNumber")
				Me.OnEditionNumberChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Copyright", DbType:="VarChar(4) NOT NULL", CanBeNull:=false)>  _
	Public Property Copyright() As String
		Get
			Return Me._Copyright
		End Get
		Set
			If (String.Equals(Me._Copyright, value) = false) Then
				Me.OnCopyrightChanging(value)
				Me.SendPropertyChanging
				Me._Copyright = value
				Me.SendPropertyChanged("Copyright")
				Me.OnCopyrightChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Title_AuthorISBN", Storage:="_AuthorISBNs", ThisKey:="ISBN", OtherKey:="ISBN")>  _
	Public Property AuthorISBNs() As EntitySet(Of AuthorISBN)
		Get
			Return Me._AuthorISBNs
		End Get
		Set
			Me._AuthorISBNs.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_AuthorISBNs(ByVal entity As AuthorISBN)
		Me.SendPropertyChanging
		entity.Title = Me
	End Sub
	
	Private Sub detach_AuthorISBNs(ByVal entity As AuthorISBN)
		Me.SendPropertyChanging
		entity.Title = Nothing
	End Sub
End Class
