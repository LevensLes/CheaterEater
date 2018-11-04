Namespace My
    Partial Friend Class MyApplication
        Private WithEvents domain As AppDomain = AppDomain.CurrentDomain
        Private Function domaincheck(sender As Object, e As System.ResolveEventArgs) As System.Reflection.Assembly Handles domain.AssemblyResolve
            If e.Name.Contains("MySql.Data") Then
                Return System.Reflection.Assembly.Load(My.Resources.MySql_Data)
            Else
                Return Nothing

            End If
        End Function
    End Class
End Namespace
