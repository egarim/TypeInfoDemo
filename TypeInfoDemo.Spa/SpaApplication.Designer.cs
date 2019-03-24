namespace TypeInfoDemo.Spa
{
    partial class TypeInfoDemoSpaApplication
    {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Spa.SystemModule.SystemSpaModule module2;
        private TypeInfoDemo.Module.TypeInfoDemoModule module3;
        private TypeInfoDemo.Module.Spa.TypeInfoDemoSpaModule module4;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule objectsModule;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;

        private void InitializeComponent()
        {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Spa.SystemModule.SystemSpaModule();
            this.module3 = new TypeInfoDemo.Module.TypeInfoDemoModule();
            this.module4 = new TypeInfoDemo.Module.Spa.TypeInfoDemoSpaModule();
            this.objectsModule = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.conditionalAppearanceModule = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();

            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();


            // 
            // TypeInfoDemoSpaApplication
            // 
            this.ApplicationName = "TypeInfoDemo";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.objectsModule);
            this.Modules.Add(this.conditionalAppearanceModule);
            this.Modules.Add(this.validationModule);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.TypeInfoDemoSpaApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

    }
}