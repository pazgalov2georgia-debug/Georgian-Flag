Console.Write("Please, specify the number of floors: ");
int totalFloors = int.Parse(Console.ReadLine());
Console.Write("Please, specify the number of bulding entrances: ");
int totalEntrances = int.Parse(Console.ReadLine());
Console.Write("Please, specify the number of apatments per floor: ");
int roomsPerFloor = int.Parse(Console.ReadLine());


const int CellWidth = 4;

for (int floor = totalFloors - 1; floor >= 0; floor--)
{
    for (int entrance = 0; entrance < totalEntrances; entrance++)
    {
        for (int roomOnFloorIndex = 0; roomOnFloorIndex < roomsPerFloor; roomOnFloorIndex++)
        {
            var WindowInd = (roomOnFloorIndex + 1) + floor * roomsPerFloor + entrance * roomsPerFloor * totalFloors;

            Console.ForegroundColor = GetRoomColor(roomOnFloorIndex, floor, entrance, totalFloors, totalEntrances, roomsPerFloor);
            //Console.Write($"[{WindowInd,CellWidth}]");
            Console.Write($"[{WindowInd:D3}]");
            // Thread.Sleep(1000);
        }
        // Console.Write(" ");
    }
    Console.WriteLine();
}

static ConsoleColor GetRoomColor(int roomOnFloorIndex, int floor, int entrance, int totalFloors, int totalEntrances, int roomsPerFloor)
{
    int bldWidth = roomsPerFloor * totalEntrances;
    int bldHight = totalFloors;

    int roomX = roomOnFloorIndex + entrance * roomsPerFloor;
    int roomY = floor;
    int midX = bldWidth / 2;
    int midY = bldHight / 2;
    int smallCrossXLeft = midX / 2;
    int smallCrossXRight = midX + (bldWidth - midX) / 2;
    int smallCrossYUp = midY + (bldHight - midY) / 2;
    int smallCrossYDown = midY / 2;



    if (roomX == bldWidth / 2 || roomY == bldHight / 2) //big cross
    {
        return ConsoleColor.Red;
    }
    //Define Angles Apts for all Crosses
    bool is1CrossCorners = roomX == smallCrossXLeft - 1 && roomY == smallCrossYDown - 1 || roomX == smallCrossXLeft + 1 && roomY == smallCrossYDown + 1 || roomX == smallCrossXLeft + 1 && roomY == smallCrossYDown - 1 || roomX == smallCrossXLeft - 1 && roomY == smallCrossYDown + 1;
    bool is2CrossCorners = roomX == smallCrossXLeft - 1 && roomY == smallCrossYUp - 1 || roomX == smallCrossXLeft + 1 && roomY == smallCrossYUp + 1 || roomX == smallCrossXLeft + 1 && roomY == smallCrossYUp - 1 || roomX == smallCrossXLeft - 1 && roomY == smallCrossYUp + 1;
    bool is3CrossCorners = roomX == smallCrossXRight - 1 && roomY == smallCrossYUp - 1 || roomX == smallCrossXRight + 1 && roomY == smallCrossYUp + 1 || roomX == smallCrossXRight + 1 && roomY == smallCrossYUp - 1 || roomX == smallCrossXRight - 1 && roomY == smallCrossYUp + 1;
    bool is4CrossCorners = roomX == smallCrossXRight - 1 && roomY == smallCrossYDown - 1 || roomX == smallCrossXRight + 1 && roomY == smallCrossYDown + 1 || roomX == smallCrossXRight + 1 && roomY == smallCrossYDown - 1 || roomX == smallCrossXRight - 1 && roomY == smallCrossYDown + 1;
    //Remove Angles for all Crosses
    if (is1CrossCorners || is2CrossCorners || is3CrossCorners || is4CrossCorners)
    {
        return ConsoleColor.White;
    }

    if (roomX >= smallCrossXLeft - 1 && roomX <= smallCrossXLeft + 1 && roomY >= smallCrossYDown - 1 && roomY <= smallCrossYDown + 1) //small cross #1
    {
        return ConsoleColor.Red;
    }


    if (roomX >= smallCrossXLeft - 1 && roomX <= smallCrossXLeft + 1 && roomY >= smallCrossYUp - 1 && roomY <= smallCrossYUp + 1) //small cross #2
    {
        return ConsoleColor.Red;
    }

    if (roomX >= smallCrossXRight - 1 && roomX <= smallCrossXRight + 1 && roomY >= smallCrossYUp - 1 && roomY <= smallCrossYUp + 1) //small cross #3
    {
        return ConsoleColor.Red;
    }

    if (roomX >= smallCrossXRight - 1 && roomX <= smallCrossXRight + 1 && roomY >= smallCrossYDown - 1 && roomY <= smallCrossYDown + 1) //small cross #4
    {
        return ConsoleColor.Red;
    }
    return ConsoleColor.Gray;

}
