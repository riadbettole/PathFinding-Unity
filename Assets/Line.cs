using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Line {

    const float verticalLineGradient = 1e5f;

    float gradient;
    float y_intercept;

    float gradientPerpendicular;

    /*public Line(Vector2 pointOnLine, Vector2 pointPerpendicularToLine)
    {
        float dx = pointOnLine.x - pointPerpendicularToLine.x;
        float dy = pointOnLine.y - pointPerpendicularToLine.y;

        if(dx == 0)
        {
            gradientPerpendicular = verticalLineGradient;
        }
        else
        {
            gradientPerpendicular = dy / dx;
        }

        gradient = -1 / gradientPerpendicular

    }*/
}
