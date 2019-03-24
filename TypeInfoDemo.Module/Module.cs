using System;
using System.Text;
using System.Linq;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using System.Collections.Generic;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Model.Core;
using DevExpress.ExpressApp.Model.DomainLogics;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Xpo;
using LibreriaDeTerceros;
using DevExpress.ExpressApp.Validation;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Validation;

namespace TypeInfoDemo.Module
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
    public sealed partial class TypeInfoDemoModule : ModuleBase
    {
        public TypeInfoDemoModule()
        {
            InitializeComponent();
            BaseObject.OidInitializationMode = OidInitializationMode.AfterConstruction;
        }

        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB)
        {
            ModuleUpdater updater = new DatabaseUpdate.Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }

        public override void Setup(XafApplication application)
        {
            base.Setup(application);
            // Manage various aspects of the application UI and behavior at the module level.
        }

        public override void CustomizeTypesInfo(ITypesInfo typesInfo)
        {
            base.CustomizeTypesInfo(typesInfo);
            CalculatedPersistentAliasHelper.CustomizeTypesInfo(typesInfo);

            ITypeInfo ClienteTypeInfo = typesInfo.FindTypeInfo(typeof(Cliente));
            if (ClienteTypeInfo != null)
            {
                ClienteTypeInfo.AddAttribute(new DefaultClassOptionsAttribute());
                ClienteTypeInfo.AddAttribute(new ModelDefaultAttribute("Caption", "Clase de Cliente"));
                AppearanceAttribute attribute = new AppearanceAttribute("Back Color Red");

                attribute.TargetItems = "*";
                attribute.BackColor = "Red";

                ClienteTypeInfo.AddAttribute(attribute);

                var NombreMemberInfo = ClienteTypeInfo.OwnMembers.Where(m => m.Name == "Nombre").FirstOrDefault();
                if (NombreMemberInfo != null)
                {
                    NombreMemberInfo.AddAttribute(new RuleRequiredFieldAttribute("Nombre es requerido", DefaultContexts.Save));
                }
            }
        }
    }
}