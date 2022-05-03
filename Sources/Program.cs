

GameWindowSettings _gameWindowSettings;
NativeWindowSettings _nativeWindowSettings;


_gameWindowSettings = new GameWindowSettings();
_gameWindowSettings.IsMultiThreaded = false;
_gameWindowSettings.UpdateFrequency = 0.0;
_gameWindowSettings.RenderFrequency = 144.0;

_nativeWindowSettings = new NativeWindowSettings();
_nativeWindowSettings.IsFullscreen = false;
_nativeWindowSettings.Size = new Vector2i(1920, 1080);
_nativeWindowSettings.Title = "G.L.O.O. Engine";


using (Game game = new Game(_gameWindowSettings, _nativeWindowSettings))
{

    game.Run();
}