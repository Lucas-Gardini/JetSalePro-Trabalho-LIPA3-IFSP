﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JetSalePro.Properties {
    using System;
    
    
    /// <summary>
    ///   Uma classe de recurso de tipo de alta segurança, para pesquisar cadeias de caracteres localizadas etc.
    /// </summary>
    // Essa classe foi gerada automaticamente pela classe StronglyTypedResourceBuilder
    // através de uma ferramenta como ResGen ou Visual Studio.
    // Para adicionar ou remover um associado, edite o arquivo .ResX e execute ResGen novamente
    // com a opção /str, ou recrie o projeto do VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retorna a instância de ResourceManager armazenada em cache usada por essa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("JetSalePro.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Substitui a propriedade CurrentUICulture do thread atual para todas as
        ///   pesquisas de recursos que usam essa classe de recurso de tipo de alta segurança.
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
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap add {
            get {
                object obj = ResourceManager.GetObject("add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap alert {
            get {
                object obj = ResourceManager.GetObject("alert", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap back {
            get {
                object obj = ResourceManager.GetObject("back", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap back1 {
            get {
                object obj = ResourceManager.GetObject("back1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap cart_outline {
            get {
                object obj = ResourceManager.GetObject("cart-outline", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta uma cadeia de caracteres localizada semelhante a CREATE DATABASE IF NOT EXISTS jet_sale_pro;
        ///
        ///USE jet_sale_pro;
        ///
        ///CREATE TABLE IF NOT EXISTS produtos (
        ///    codigo_produto INT AUTO_INCREMENT PRIMARY KEY NOT NULL,
        ///    descricao VARCHAR(100) NOT NULL,
        ///    codigo_barras INT(13) UNIQUE NOT NULL,
        ///    marca VARCHAR(50) NOT NULL,
        ///    peso FLOAT NOT NULL,
        ///    largura FLOAT NOT NULL,
        ///    altura FLOAT NOT NULL,
        ///    profundidade FLOAT NOT NULL,
        ///    situacao BOOLEAN NOT NULL,
        ///    condicao VARCHAR(5) NOT NULL CHECK (condicao IN (&apos;Novo&apos;, &apos;Usado&apos;)),
        ///    pre [o restante da cadeia de caracteres foi truncado]&quot;;.
        /// </summary>
        internal static string database {
            get {
                return ResourceManager.GetString("database", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap delete {
            get {
                object obj = ResourceManager.GetObject("delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap edit {
            get {
                object obj = ResourceManager.GetObject("edit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Invisible {
            get {
                object obj = ResourceManager.GetObject("Invisible", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Invisible1 {
            get {
                object obj = ResourceManager.GetObject("Invisible1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap loading {
            get {
                object obj = ResourceManager.GetObject("loading", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Login {
            get {
                object obj = ResourceManager.GetObject("Login", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Login1 {
            get {
                object obj = ResourceManager.GetObject("Login1", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Logo {
            get {
                object obj = ResourceManager.GetObject("Logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Logo_Square {
            get {
                object obj = ResourceManager.GetObject("Logo_Square", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Icon semelhante a (Ícone).
        /// </summary>
        internal static System.Drawing.Icon Logo1 {
            get {
                object obj = ResourceManager.GetObject("Logo1", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap Logo2 {
            get {
                object obj = ResourceManager.GetObject("Logo2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap search {
            get {
                object obj = ResourceManager.GetObject("search", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap success {
            get {
                object obj = ResourceManager.GetObject("success", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Consulta um recurso localizado do tipo System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap user {
            get {
                object obj = ResourceManager.GetObject("user", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
