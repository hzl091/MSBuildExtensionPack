//-----------------------------------------------------------------------
// <copyright file="GlobalSuppressions.cs">(c) http://www.codeplex.com/MSBuildExtensionPack. This source is subject to the Microsoft Permissive License. See http://www.microsoft.com/resources/sharedsource/licensingbasics/sharedsourcelicenses.mspx. All other rights reserved.</copyright>
//-----------------------------------------------------------------------
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames", Justification = "Delay Signed")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Detokenise", Scope = "type", Target = "MSBuild.ExtensionPack.FileSystem.Detokenise", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Detokenised", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Detokenise.#FilesDetokenised", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Filecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#ExcludedFilecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Filecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#IncludedFilecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Filecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#TotalFilecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Linecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#CodeLinecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Linecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#CommentLinecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Linecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#EmptyLinecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Linecount", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#TotalLinecount", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Maths", Scope = "type", Target = "MSBuild.ExtensionPack.Science.Maths", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Multi", Scope = "member", Target = "MSBuild.ExtensionPack.Computer.PerformanceCounters.#MultiInstance", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.BaseTask.#Execute()", Justification = "Base Catch All")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "MailTo", Scope = "member", Target = "MSBuild.ExtensionPack.Communication.Email.#MailTo", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tfs", Scope = "type", Target = "MSBuild.ExtensionPack.VisualStudio.TfsVersion", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tfs", Scope = "type", Target = "MSBuild.ExtensionPack.VisualStudio.TfsSource", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tfs", Scope = "member", Target = "MSBuild.ExtensionPack.VisualStudio.TfsVersion.#TfsBuildNumber", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Tfs", Scope = "type", Target = "MSBuild.ExtensionPack.VisualStudio.TfsSourceAdmin", Justification = "The spelling is fine")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Multimedia", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Management.Wmi.#Query()", Justification = "TODO: This is by design, but needs reviewing.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Scope = "member", Target = "MSBuild.ExtensionPack.Computer.ComponentServices.#IsValidAssemblyFile(System.String)", Justification = "TODO: Unclear about the actual implication and need to fix this issue.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.Reflection.Assembly.LoadFrom", Scope = "member", Target = "MSBuild.ExtensionPack.Framework.Assembly.#InternalExecute()", Justification = "TODO: Unclear about the actual implication and need to fix this issue.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.File.#CommentIdentifiers", Justification = "TODO: This is by design, but needs reviewing.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1044:PropertiesShouldNotBeWriteOnly", Scope = "member", Target = "MSBuild.ExtensionPack.Science.Maths.#Numbers", Justification = "TODO: This is by design, but needs reviewing.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Detokenise.#ProcessFolder(System.Collections.Generic.IEnumerable`1<System.IO.FileSystemInfo>)", Justification = "TODO: Needs reviewing.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Folder.#RemoveContent(System.IO.DirectoryInfo)", Justification = "TODO: Needs reviewing.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.CodeQuality", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Compression", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Misc", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Management", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Communication", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.EnterpriseServices", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.FileSystem", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Science", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.UI", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Crypto", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Gac", Scope = "type", Target = "MSBuild.ExtensionPack.Framework.Gac")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage", Scope = "member", Target = "MSBuild.ExtensionPack.Framework.NativeMethods.#CreateAssemblyCache(MSBuild.ExtensionPack.Framework.NativeMethods+IAssemblyCache&,System.Int32)", Justification = "TODO: Review this.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage", Scope = "member", Target = "MSBuild.ExtensionPack.Computer.NativeMethods.#SendMessageTimeout(System.Int32,System.Int32,System.Int32,System.String,System.Int32,System.Int32,System.Int32)", Justification = "TODO: Review this.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Security", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.FileSystem", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.UI.Extended", Justification = "Done to hide from Sandcastle documentation")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Share.#CheckExists()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Share.#Delete()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colour", Scope = "member", Target = "MSBuild.ExtensionPack.UI.Extended.PromptForm.#.ctor(System.String,System.String,System.Boolean,System.String,System.String,System.String,System.Boolean)", Justification = "Correct spelling")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colour", Scope = "member", Target = "MSBuild.ExtensionPack.UI.Extended.MessageForm.#.ctor(System.String,System.String,System.Boolean,System.String,System.String,System.String)", Justification = "Correct spelling")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Colour", Scope = "member", Target = "MSBuild.ExtensionPack.UI.Dialog.#MessageColour", Justification = "Correct spelling")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Share.#GetSecurityIdentifier(System.Management.ManagementBaseObject)", Justification = "Intended use")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.FileSystem.Share.#GetAccount(System.String,System.String)", Justification = "Intended use")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Web", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6Website.#Create()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Deletable", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6ServiceExtensionFile.#Deletable", Justification = "Spelling correct")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6AppPool.#LoadAppPools()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6ServiceExtensionFile.#AddFile()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6ServiceExtensionFile.#DeleteFile()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6VirtualDirectory.#Create()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Web.Iis6VirtualDirectory.#LoadWebService()", Justification = "Intended usage")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "MSBuild.ExtensionPack.Xml", Justification = "Growing Library")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MSBuild.ExtensionPack.Framework.AssemblyInfo.#GetTemporaryFileInfo()", Justification = "Intended usage")]
