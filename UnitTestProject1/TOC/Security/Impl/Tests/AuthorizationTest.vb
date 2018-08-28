Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class AuthorizationTest

    <TestMethod()> Public Sub 指定したパスのアクセストークンが取得できる()
        Dim target = New TOC.Security.Impl.Authorization()

        Dim filePath = Environment.CurrentDirectory + "\Resources\AccessToken\TestToken.txt"

        Dim token = target.GetAccessToken(filePath)

        Assert.AreEqual("hogehoge", token)
    End Sub

    <TestMethod()> Public Sub 存在しないファイルはエラーになる()
        Dim target = New TOC.Security.Impl.Authorization()

        Dim filePath = Environment.CurrentDirectory + "\Resources\AccessToken\TestTokenFail.txt"

        Try
            Dim token = target.GetAccessToken(filePath)
            Assert.Fail()
        Catch ex As Exception
            Assert.IsInstanceOfType(ex, GetType(IO.FileNotFoundException))
        End Try
    End Sub

    <TestMethod()> Public Sub パスを指定しない場合はデフォルトパスを読みに行く()
        Dim target = New TOC.Security.Impl.Authorization()

        ' TODO
        ' デフォルトパスを読むことをどうやってチェックすればよいか？
    End Sub

End Class