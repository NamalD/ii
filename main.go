package main

import (
	"fyne.io/fyne/v2/app"
	"fyne.io/fyne/v2/canvas"
	"os"
)

func main() {
	// TODO: Keybindings
	// TODO: Next/previous image in folder
	// TODO: Hide window borders
	if len(os.Args) < 2 {
		return
	}

	iiApp := app.New()
	window := iiApp.NewWindow("ii")

	filename := os.Args[1]
	window.SetTitle("ii: " + filename)
	image := canvas.NewImageFromFile(filename)
	image.FillMode = canvas.ImageFillOriginal
	window.SetContent(image)

	window.ShowAndRun()
}
