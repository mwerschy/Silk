﻿using System;
using System.Linq;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using Newtonsoft.Json;
using Silk.Core.Utilities;

namespace Silk.Core.Commands.General
{
    [Category(Categories.General)]
    public class AvatarCommand : BaseCommandModule
    {
        [Command]
        [Description("Show your, or someone else's avatar!")]
        [Aliases("av")]
        public async Task Avatar(CommandContext ctx)
        {
            var builder = new DiscordMessageBuilder();
            builder.WithReply(ctx.Message.Id);
            builder.WithEmbed(DefaultAvatarEmbed(ctx).WithAuthor(ctx.User.Username, iconUrl: ctx.User.AvatarUrl)
                .WithTitle($"Your Avatar!")
                .WithImageUrl(AvatarImageResizedUrl(ctx.User.AvatarUrl)));
            await ctx.RespondAsync(builder);
        }
        
        [Command("avatar")]
        [Description("Show your, or someone else's avatar!")]
        public async Task GetAvatarAsync(CommandContext ctx, DiscordUser user)
        {
            DiscordEmbedBuilder embedBuilder = DefaultAvatarEmbed(ctx)
                .WithAuthor(ctx.User.Username, iconUrl: ctx.User.AvatarUrl)
                .WithDescription($"{user.Mention}'s Avatar")
                .WithImageUrl(AvatarImageResizedUrl(user.AvatarUrl));

            await ctx.RespondAsync(embedBuilder);
        }

        [Command("avatar")]
        public async Task GetAvatarAsync(CommandContext ctx, [RemainingText] string user)
        {
            
            DiscordMember? userObj = ctx.Guild.Members.Values.FirstOrDefault(u => u.Username.Contains(user, StringComparison.OrdinalIgnoreCase));

            if (userObj is null)
                await ctx.RespondAsync("Sorry, I couldn't find anyone with a name matching the text provided.");
            else
            {
                await ctx.RespondAsync(
                    DefaultAvatarEmbed(ctx)
                        .WithAuthor(ctx.User.Username, iconUrl: ctx.User.AvatarUrl)
                        .WithDescription($"{userObj.Mention}'s Avatar")
                        .WithImageUrl(AvatarImageResizedUrl(userObj.AvatarUrl)));
            }
        }

        private static string AvatarImageResizedUrl(string avatarUrl) => avatarUrl.Replace("128", "4096&v=1");

        private static DiscordEmbedBuilder DefaultAvatarEmbed(CommandContext ctx) =>
            new DiscordEmbedBuilder()
                .WithColor(DiscordColor.CornflowerBlue)
                .WithFooter($"Silk! | Requested by {ctx.User.Username}/{ctx.User.Id}", ctx.User.AvatarUrl);

    }
}