Imports System.Web.Mvc
Imports ComicBookGalleryVB.Models
Imports ComicBookGalleryVB.Data

Namespace Controllers
    Public Class ComicBookController : Inherits Controller
        Private ReadOnly _comicBookRepository As ComicBookRepository

        Public Sub New()
            _comicBookRepository = New ComicBookRepository()
        End Sub

        Function Index() As ActionResult
            Dim comicBooks = _comicBookRepository.GetComicBooks()

            Return View(comicBooks)
        End Function

        Function Detail(id As Integer?) As ActionResult
            If Not id.HasValue Then
                Return HttpNotFound()
            End If

            Dim comicBook = _comicBookRepository.GetComicBook(id)

            Return View(comicBook)
        End Function
    End Class
End Namespace
