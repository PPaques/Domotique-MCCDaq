using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

public class FireColdPannel : DrawingArea
{
    protected override void OnDraw()
    {
        // Gets the image from the global resources
        Image broculoImage = global::MyhouseDomotique.Properties.Resources.FireCold;

        // Sets the images' sizes and positions
        int width = broculoImage.Size.Width;
        int height = broculoImage.Size.Height;
        Rectangle small = new Rectangle(0, 0, (int)(0.5 * width), (int)(0.5 * height));

        // Draws the two images
        this.graphics.DrawImage(broculoImage, small);
    }
}
public class FireHotPannel : DrawingArea
{
    protected override void OnDraw()
    {
        // Gets the image from the global resources
        Image broculoImage = global::MyhouseDomotique.Properties.Resources.FireHot;

        // Sets the images' sizes and positions
        int width = broculoImage.Size.Width;
        int height = broculoImage.Size.Height;
        Rectangle small = new Rectangle(0, 0, (int)(0.5 * width), (int)(0.5 * height));

        // Draws the two images
        this.graphics.DrawImage(broculoImage, small);
    }
}
public class LighActivePannel : DrawingArea
{
    protected override void OnDraw()
    {
        // Gets the image from the global resources
        Image broculoImage = global::MyhouseDomotique.Properties.Resources.light_active;

        // Sets the images' sizes and positions
        int width = broculoImage.Size.Width;
        int height = broculoImage.Size.Height;
        Rectangle small = new Rectangle(0, 0, (int)(0.25 * width), (int)(0.25 * height));

        // Draws the two images
        this.graphics.DrawImage(broculoImage, small);
    }
}
public class LighInactivePannel : DrawingArea
{
    protected override void OnDraw()
    {
        // Gets the image from the global resources
        Image broculoImage = global::MyhouseDomotique.Properties.Resources.light_inactive;

        // Sets the images' sizes and positions
        int width = broculoImage.Size.Width;
        int height = broculoImage.Size.Height;
        Rectangle small = new Rectangle(0, 0, (int)(0.25 * width), (int)(0.25 * height));

        // Draws the two images
        this.graphics.DrawImage(broculoImage, small);
    }
}
