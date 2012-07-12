Imports EasyHttp.Http
Imports ServiceStackModel.Request

Module Module1

    Sub Main()
        Dim http = New HttpClient()
        http.Request.Accept = HttpContentTypes.ApplicationJson
        Dim response = http.Get("http://localhost:3318/plant/test?format=json")
        Dim plant = response.DynamicBody
        Console.WriteLine(plant.Name)
        Console.ReadLine()
    End Sub

End Module
