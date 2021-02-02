package main

import (
    "fyne.io/fyne/v2"
    "fyne.io/fyne/v2/app"
    "fyne.io/fyne/v2/canvas"
)

func main() {
    // TODO: Load image from arg
    // TODO: Keybindings
    // TODO: Next/previous image in folder
    // TODO: Hide window borders

    app := app.New()
    window := app.NewWindow("Hello")

    image := canvas.NewImageFromFile("P1200182.png")
    image.FillMode = canvas.ImageFillOriginal
    window.SetContent(image)

    window.Resize(fyne.NewSize(800, 600))
    window.ShowAndRun()
}
