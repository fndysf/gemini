﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gemini.Modules.ErrorList.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Gemini.Modules.ErrorList.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Column.
        /// </summary>
        internal static string ErrorListHeaderColumn {
            get {
                return ResourceManager.GetString("ErrorListHeaderColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Description.
        /// </summary>
        internal static string ErrorListHeaderDescription {
            get {
                return ResourceManager.GetString("ErrorListHeaderDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на File.
        /// </summary>
        internal static string ErrorListHeaderFile {
            get {
                return ResourceManager.GetString("ErrorListHeaderFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Line.
        /// </summary>
        internal static string ErrorListHeaderLine {
            get {
                return ResourceManager.GetString("ErrorListHeaderLine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Errors.
        /// </summary>
        internal static string ErrorTextPlural {
            get {
                return ResourceManager.GetString("ErrorTextPlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Error.
        /// </summary>
        internal static string ErrorTextSingular {
            get {
                return ResourceManager.GetString("ErrorTextSingular", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Messages.
        /// </summary>
        internal static string MessageTextPlural {
            get {
                return ResourceManager.GetString("MessageTextPlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Message.
        /// </summary>
        internal static string MessageTextSingular {
            get {
                return ResourceManager.GetString("MessageTextSingular", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error L_ist.
        /// </summary>
        internal static string ViewErrorListCommandText {
            get {
                return ResourceManager.GetString("ViewErrorListCommandText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Error List.
        /// </summary>
        internal static string ViewErrorListCommandToolTip {
            get {
                return ResourceManager.GetString("ViewErrorListCommandToolTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Warnings.
        /// </summary>
        internal static string WarningTextPlural {
            get {
                return ResourceManager.GetString("WarningTextPlural", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0} Warning.
        /// </summary>
        internal static string WarningTextSingular {
            get {
                return ResourceManager.GetString("WarningTextSingular", resourceCulture);
            }
        }
    }
}
