Imports ServiceStackModel.Request
Imports ServiceStackModel.Response
Imports ServiceStack.ServiceClient.Web

Module Module1

    Sub Main()
        Dim client = New JsonServiceClient("http://localhost:3318")
        Dim response = client.Send(Of PlantResponse)(New PlantRequest With {.Name = "World!"})
        Console.WriteLine(response.Name)
        Console.ReadLine()
    End Sub

End Module
