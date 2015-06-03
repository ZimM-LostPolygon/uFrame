// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

using uFrame.IOC;
using uFrame.Kernel;
using uFrame.MVVM;

namespace uFrame.DefaultProject {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.DefaultProject;
    
    
    public class GameSystemLoaderBase : SystemLoader {
        
        private LoadingScreenViewModel _LoadingScreen;
        
        private LoadingScreenController _LoadingScreenController;
        
        [Inject("LoadingScreen")]
        public virtual LoadingScreenViewModel LoadingScreen {
            get {
                if (this._LoadingScreen == null) {
                    this._LoadingScreen = this.CreateViewModel<LoadingScreenViewModel>( "LoadingScreen");
                }
                return _LoadingScreen;
            }
            set {
            }
        }
        
        [InjectAttribute()]
        public virtual LoadingScreenController LoadingScreenController {
            get {
                if (_LoadingScreenController==null) {
                    _LoadingScreenController = Container.CreateInstance(typeof(LoadingScreenController)) as LoadingScreenController;;
                }
                return _LoadingScreenController;
            }
            set {
                _LoadingScreenController = value;
            }
        }
        
        public override void Load() {
            Container.RegisterViewModelManager<LoadingScreenViewModel>(new ViewModelManager<LoadingScreenViewModel>());
            Container.RegisterController<LoadingScreenController>(LoadingScreenController);
            Container.RegisterViewModel<LoadingScreenViewModel>(LoadingScreen, "LoadingScreen");
        }
    }
}
