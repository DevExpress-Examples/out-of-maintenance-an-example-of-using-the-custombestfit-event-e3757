Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace WpfApplication5
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
			Dim source() As String = { "123456789", "1234567890", "12345678901", "123456789012" }
			gridControl1.ItemsSource = source

		End Sub
		Private Sub tableView1_CustomBestFit(ByVal sender As Object, ByVal e As DevExpress.Xpf.Grid.CustomBestFitEventArgs)
			Dim selectedRows As New LinkedList(Of Integer)()
			For Each item As ListBoxItem In listBoxEdit1.SelectedItems
				If item.IsEnabled Then
					selectedRows.AddLast(Convert.ToInt32(item.Content))
				End If
			Next item
			e.BestFitRows = selectedRows
		End Sub
	End Class
End Namespace
