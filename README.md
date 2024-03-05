# Billard-game

Stages and rules:
A normal billard game that contains four stages.
First stage - putting all the balls in the holes without any complications.
Second stage - the goal is to get as many points as possible.
The way the points are accumulated is - the computer randomly choose a color from the colors left on the table and if the player manages to insert this color then he gets 2 points, inserting another ball is worth 1 point and inserting the white ball subtracts a point.
Third stage - insertion of more than two balls in a period of 20 seconds.
Fourth stage - is a combination of the two previous stages and its goal is to obtain as many points as possible according to the rules of the second stage while having a time limit of 30 seconds.

Way of play:
The operation of the game is very simple.
You have to put the mouse on the white ball and pull back against the direction you want the ball to go, the harder you pull, the stronger the blow will be.
If a ball falls into the hole it does not return except for the cue ball which returns to its starting point.

Parts of code:

A function that converts the position of the mouse to the known coordinates -

 if(Input.GetMouseButtonDown(0)){
            startpoint = cam.ScreenToWorldPoint(Input.mousePosition);
            }

Conversion of the distance between the clicks of the mouse to force and its addition to the acceleration of the white ball=
ש
  force = new Vector2(Mathf.Clamp(startpoint.x - endpoint.x,minpow.x,maxpow.x),Mathf.Clamp(startpoint.y - endpoint.y,minpow.y,maxpow.y));
            rb.AddForce(force * power,ForceMode2D.Impulse);

function to render the line behind the ball according to the mouse clicks - 

 public void RenderLine(Vector3 startpoint,Vector3 endpoint){
        lr.positionCount = 2;
        Vector3[] points = new Vector3[2];
        points[0] = startpoint;
        points[1] = endpoint;

        lr.SetPositions(points);

Trigger resistance between the ball and the holes so that the ball will be swallowed into the hole and destroyed unless it is the white then it returns to its initial place - 

private void OnTriggerEnter2D(Collider2D collision)
    {
        if(gameObject.name == "White"){
            gameObject.transform.position = new Vector3(1, 1, 0);
            rb = GetComponent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
        }
        else
            Destroy(gameObject);

 if(color_name == "White"){
            score--;
        }
        else if(color_name == t_color.text){
            score+= 2;
        }
        else{
            score++;
        }
        
        t_score.text = score.ToString(); 

randomly choose a color for stages 2,4 -

var rnd = new System.Random();
        int index = rnd.Next(colors.Count);
        t_color.text = colors[index];  

timer function and activate him by a click on the button

    if(isUpdateEnable){
            timeLeft -= Time.deltaTime;
            t_timer.text = (timeLeft).ToString("0");
            if(timeLeft < 0){
                int score = gn.Sc(8);
                go.Setup(score);
                isUpdateEnable = false;
            }
        }     

Line to for play the game onlone on itch pllatform - https://yoyo1516.itch.io/billard-game

Enjoy the game:))
        
