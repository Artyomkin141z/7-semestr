open System

[<EntryPoint>]
let main argv =
    let printerAgent = MailboxProcessor.Start(fun inbox->
        // обработка сообщений
        let rec messageLoop() = async{
            // чтение сообщения
            let! msg = inbox.Receive()
            // печать сообщения
            printfn "Сообщение: %s" msg
            return! messageLoop()
            }
        // запуск обработки сообщений
        messageLoop()
        )

    printerAgent.Post "Сообщение 1"
    printerAgent.Post "Сообщение 2"

    //|> ignore - перенаправление потока с игнорирование результата вычисления
    Console.ReadLine() |> ignore
    0 // возвращение целочисленного кода выхода


