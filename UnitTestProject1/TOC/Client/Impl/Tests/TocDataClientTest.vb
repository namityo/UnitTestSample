Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TocDataClientTest

    <TestMethod()> Public Sub アクセストークンが無い場合にエラーになる()
        Dim target = New TOC.Client.Impl.TocDataClient()

        Try
            Dim result = target.GetOdakyuFare("")
            Assert.Fail()
        Catch ex As Exception
            Assert.IsInstanceOfType(ex, GetType(Net.WebException))
        End Try
    End Sub

    <TestMethod()> Public Sub アクセストークンが正常であればエラーにならない()
        Dim target = New TOC.Client.Impl.TocDataClient()

        ' TODO
        ' 正常なアクセストークンが必要なテスト
        ' アクセストークンはコミットできない問題を解決する必要がある
        ' 一番の正解は、テスト実行時にテスト用Webサーバーが起動する仕組みを入れること
        Dim result = target.GetOdakyuFare("正常なアクセストークン")
        StringAssert.Contains(result, "@id")
    End Sub

End Class