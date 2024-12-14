open System
open System.Windows.Forms
open System.Collections.Generic

let form = new Form(Text = "Contact Management System", Width = 400, Height = 400)

let nameLabel = new Label(Text = "Name:", Top = 20, Left = 20)
let nameTextBox = new TextBox(Top = 20, Left = 100, Width = 200)

let phoneLabel = new Label(Text = "Phone:", Top = 60, Left = 20)
let phoneTextBox = new TextBox(Top = 60, Left = 100, Width = 200)

let emailLabel = new Label(Text = "Email:", Top = 100, Left = 20)
let emailTextBox = new TextBox(Top = 100, Left = 100, Width = 200)

let addButton = new Button(Text = "Add", Top = 140, Left = 20)
let editButton = new Button(Text = "Edit", Top = 140, Left = 100)
let deleteButton = new Button(Text = "Delete", Top = 140, Left = 180)
let searchButton = new Button(Text = "Search", Top = 140, Left = 260)

// إضافة كل عناصر التحكم إلى الفورم
form.Controls.AddRange([| nameLabel; nameTextBox; phoneLabel; phoneTextBox; 
                         emailLabel; emailTextBox; addButton; editButton; 
                         deleteButton; searchButton |])

Application.Run(form)