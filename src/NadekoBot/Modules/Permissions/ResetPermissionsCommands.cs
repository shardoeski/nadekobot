using Discord;
using Discord.Commands;
using System.Threading.Tasks;
using NadekoBot.Common.Attributes;
using NadekoBot.Modules.Permissions.Services;

namespace NadekoBot.Modules.Permissions
{
    public partial class Permissions
    {
        [Group]
        public class ResetPermissionsCommands : NadekoSubmodule
        {
            private readonly GlobalPermissionService _gps;
            private readonly PermissionService _perms;

            public ResetPermissionsCommands(GlobalPermissionService gps, PermissionService perms)
            {
                _gps = gps;
                _perms = perms;
            }

            [NadekoCommand, Aliases]
            [RequireContext(ContextType.Guild)]
            [UserPerm(GuildPerm.Administrator)]
            public async Task ResetPerms()
            {
                await _perms.Reset(ctx.Guild.Id).ConfigureAwait(false);
                await ReplyConfirmLocalizedAsync(strs.perms_reset).ConfigureAwait(false);
            }

            [NadekoCommand, Aliases]
            [OwnerOnly]
            public async Task ResetGlobalPerms()
            {
                await _gps.Reset();
                await ReplyConfirmLocalizedAsync(strs.global_perms_reset).ConfigureAwait(false);
            }
        }
    }
}
