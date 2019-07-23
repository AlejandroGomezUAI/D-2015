Imports System.Globalization
Imports System.Threading

Namespace Idiomas

    Public Class Idioma

        ''' <summary>
        ''' Propiedad para guardar el idioma de forma temporal
        ''' </summary>
        Public Shared cacheIdioma As String = "Español"

        ''' <summary>
        ''' Metodo para cambiar el idioma del sistema
        ''' </summary>
        ''' <param name="idioma">Recibe "Ingles" o "Español"</param>
        ''' <param name="metodo">parametro que recibe un metodo con retorno void y parametro string (Delegado)</param>
        Public Shared Sub cambiarIdioma(idioma As String, metodo As Action(Of String))

            If idioma = "Ingles" Then
                'Selecciona el archivo Res.en-US.resx
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
                metodo(Nothing)

            End If
            If idioma = "Español" Then
                'Selecciona el archivo Res.resx
                Thread.CurrentThread.CurrentUICulture = New CultureInfo("")
                metodo(Nothing)

            End If

        End Sub
    End Class
End Namespace
