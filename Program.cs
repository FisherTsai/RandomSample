bool done = new Random().Next(0, 11) >= 3;
if (done == false)
{
    throw new Exception("大失敗！");
}

int count = new Random().Next(0, 11);
Console.WriteLine(
    $"<p>成功處理 " +
    $"<span style=\"color:#00ff00; font-size:x-large\">" +
    $"{count}" +
    $"</span> 筆資料。" +
    $"</p>");
return 0;
