﻿
'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Objects
Imports System.Data.Objects.DataClasses
Imports System.Data.EntityClient
Imports System.ComponentModel
Imports System.Xml.Serialization
Imports System.Runtime.Serialization

<Assembly: EdmSchemaAttribute("6e9fc1d7-f9cb-4292-aaa0-dc89dac9f572")>

#Region "Contexts"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
Public Partial Class SchoolOrganisationEntities
    Inherits ObjectContext

    #Region "Constructors"

    ''' <summary>
    ''' Initializes a new SchoolOrganisationEntities object using the connection string found in the 'SchoolOrganisationEntities' section of the application configuration file.
    ''' </summary>
    Public Sub New()
        MyBase.New("name=SchoolOrganisationEntities", "SchoolOrganisationEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new SchoolOrganisationEntities object.
    ''' </summary>
    Public Sub New(ByVal connectionString As String)
        MyBase.New(connectionString, "SchoolOrganisationEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    ''' <summary>
    ''' Initialize a new SchoolOrganisationEntities object.
    ''' </summary>
    Public Sub New(ByVal connection As EntityConnection)
        MyBase.New(connection, "SchoolOrganisationEntities")
    MyBase.ContextOptions.LazyLoadingEnabled = true
        OnContextCreated()
    End Sub

    #End Region

    #Region "Partial Methods"

    Partial Private Sub OnContextCreated()
    End Sub

    #End Region

    #Region "ObjectSet Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    Public ReadOnly Property Teachers() As ObjectSet(Of Teacher)
        Get
            If (_Teachers Is Nothing) Then
                _Teachers = MyBase.CreateObjectSet(Of Teacher)("Teachers")
            End If
            Return _Teachers
        End Get
    End Property

    Private _Teachers As ObjectSet(Of Teacher)

    #End Region
    #Region "AddTo Methods"

    ''' <summary>
    ''' Deprecated Method for adding a new object to the Teachers EntitySet. Consider using the .Add method of the associated ObjectSet(Of T) property instead.
    ''' </summary>
    Public Sub AddToTeachers(ByVal teacher As Teacher)
        MyBase.AddObject("Teachers", teacher)
    End Sub

    #End Region
End Class

#End Region
#Region "Entities"

''' <summary>
''' No Metadata Documentation available.
''' </summary>
<EdmEntityTypeAttribute(NamespaceName:="SchoolOrganisationModel", Name:="Teacher")>
<Serializable()>
<DataContractAttribute(IsReference:=True)>
Public Partial Class Teacher
    Inherits EntityObject
    #Region "Factory Method"

    ''' <summary>
    ''' Create a new Teacher object.
    ''' </summary>
    ''' <param name="id">Initial value of the Id property.</param>
    ''' <param name="name">Initial value of the Name property.</param>
    Public Shared Function CreateTeacher(id As Global.System.Int32, name As Global.System.String) As Teacher
        Dim teacher as Teacher = New Teacher
        teacher.Id = id
        teacher.Name = name
        Return teacher
    End Function

    #End Region
    #Region "Primitive Properties"

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Id() As Global.System.Int32
        Get
            Return _Id
        End Get
        Set
            If (_Id <> Value) Then
                OnIdChanging(value)
                ReportPropertyChanging("Id")
                _Id = StructuralObject.SetValidValue(value)
                ReportPropertyChanged("Id")
                OnIdChanged()
            End If
        End Set
    End Property

    Private _Id As Global.System.Int32
    Private Partial Sub OnIdChanging(value As Global.System.Int32)
    End Sub

    Private Partial Sub OnIdChanged()
    End Sub

    ''' <summary>
    ''' No Metadata Documentation available.
    ''' </summary>
    <EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false)>
    <DataMemberAttribute()>
    Public Property Name() As Global.System.String
        Get
            Return _Name
        End Get
        Set
            If (_Name <> Value) Then
                OnNameChanging(value)
                ReportPropertyChanging("Name")
                _Name = StructuralObject.SetValidValue(value, false)
                ReportPropertyChanged("Name")
                OnNameChanged()
            End If
        End Set
    End Property

    Private _Name As Global.System.String
    Private Partial Sub OnNameChanging(value As Global.System.String)
    End Sub

    Private Partial Sub OnNameChanged()
    End Sub

    #End Region
End Class

#End Region

