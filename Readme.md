<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3575)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Wait Form - How to dynamically change labels

The [WinForms Splash Screen Manager](https://docs.devexpress.com/WindowsForms/10826/controls-and-libraries/forms-and-user-controls/splash-screen-manager) runs the [Wait Form](https://docs.devexpress.com/WindowsForms/10824/controls-and-libraries/forms-and-user-controls/splash-screen-manager/wait-form) in a separate thread. This example uses the [SetWaitFormCaption](https://docs.devexpress.com/WindowsForms/DevExpress.XtraSplashScreen.SplashScreenManager.SetWaitFormCaption(System.String)) and [SetWaitFormDescription](https://docs.devexpress.com/WindowsForms/DevExpress.XtraSplashScreen.SplashScreenManager.SetWaitFormDescription(System.String)) methods to change labels before the Wait Form is displayed.


## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
