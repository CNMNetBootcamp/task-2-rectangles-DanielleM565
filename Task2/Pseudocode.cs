//setup
single height1;
single width1;
single height2;
single width2;
single area1;
single area2;

//input
do
	{
        PUT "What is the height of the first rectangle?";
        GET height1;
	} while (!height1 = single);

do
	{
        PUT "What is the width of the first rectangle?";
        GET width1;
	} while (!width1 = single);

do
	{
        PUT "What is the height of the second rectangle?";
        GET height2;
	} while (!height2 = single);

do
	{
        PUT "What is the width of the second rectangle?";
        GET width2;
	} while (!width2 = single);


//Process
area1 = height1* width1;
area2 = height2* width2;

//Output
if (area1 > area2)
	{
        PUT "The first rectangle with the height of " + height1 + " and the width of " + width1 + " has a greater area than the second rectangle with the height of " + height2 + " and width " + width2
	} else if (area2 > area1) 
    {
        PUT "The second rectangle with the height of " + height2 + " and the width of " + width2 + " has a greater area than the second rectangle with the height of " + height1 + " and width " + width1
    } else 
    {
        PUT "The areas of the first rectangle is equal to the area of the second rectangle"

    }


