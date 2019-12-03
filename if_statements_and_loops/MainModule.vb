Module MainModule

    Sub Main()

    End Sub

    Sub Main2()
        Dim products = LoadProducts()
        Dim index As Integer = 0
        Dim sum As Decimal = 0

        Do While index < (products.Count - 1)
            Console.WriteLine(products(index).ToString())
            sum += products(index).ListPrice

            index += 1
        Loop

        Console.WriteLine("Sum: " & sum.ToString("c"))

        Console.ReadKey()
    End Sub

End Module
