from kivy.app import App
from kivy.uix.image import Image

class TestApp(App):
    def build(self):
        return Image(source='../../test.png')

TestApp().run()
