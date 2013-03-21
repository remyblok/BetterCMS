﻿namespace BetterCms.Module.Root
{
    /// <summary>
    /// Root module constants.
    /// </summary>
    public static class RootModuleConstants
    {
        /// <summary>
        /// The editable grid template.
        /// </summary>
        public const string EditableGridTemplate = "~/Areas/bcms-root/Views/Shared/EditableGrid/Grid.cshtml";

        /// <summary>
        /// The editable grid cell template.
        /// </summary>
        public const string EditableGridCellTemplate = "~/Areas/bcms-root/Views/Shared/EditableGrid/Partial/Cell.cshtml";

        /// <summary>
        /// The editable grid header template.
        /// </summary>
        public const string EditableGridHeaderTemplate = "~/Areas/bcms-root/Views/Shared/EditableGrid/Partial/Header.cshtml";

        /// <summary>
        /// The editable grid top block template.
        /// </summary>
        public const string EditableGridTopBlockTemplate = "~/Areas/bcms-root/Views/Shared/EditableGrid/Partial/TopBlock.cshtml";

        /// <summary>
        /// Module permissions.
        /// </summary>
        public static class UserRoles
        {
            /// <summary>
            /// Edit permission for:
            ///     Add/Edit Content (page, blog post, html content, SEO, edit page properties, clone, save draft, preview, sort contents,
            ///                       insert file/image into content, sitemap, redirect, view content history)
            ///     Pages Administration, Blogs Admin\Authors\Default Template, Tags, Categories, Media Manager, Files Upload, Sitemap, Redirects, etc.
            /// </summary>
            public const string EditContent = "BcmsEditContent";

            /// <summary>
            /// Publish permission for  publish \ un-publish content, restore content from history, etc.
            /// </summary>
            public const string PublishContent = "BcmsPublishContent";

            /// <summary>
            /// Delete permission for delete Content, Images, Files, Folders, etc.
            /// </summary>
            public const string DeleteContent = "BcmsDeleteContent";

            /// <summary>
            /// Administration permission for Widgets, Templates, Users, etc.
            /// </summary>
            public const string Administration = "BcmsAdministration";

            /// <summary>
            /// Multiples the roles.
            /// </summary>
            /// <param name="roles">The roles.</param>
            /// <returns>Concatenated roles.</returns>
            public static string MultipleRoles(params string[] roles)
            {
                return string.Join(",", roles);
            }
        }
    }
}