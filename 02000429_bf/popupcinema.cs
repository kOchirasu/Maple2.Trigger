using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000429_bf {
    public static class _popupcinema {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    return new StateStartSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartSetupCinematic : TriggerState {
            internal StateStartSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__PopUpCinema__0$", voice: @"ko/Npc/00002157");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene1.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__PopUpCinema__1$", voice: @"ko/Npc/00002166");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleStart03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart03 : TriggerState {
            internal StateBattleStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "infernog_nomal", duration: 8900, script: "$02000410_BF__PopUpCinema__2$", voice: @"ko/Monster/60000724");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8900)) {
                    return new StateBattleStart04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart04 : TriggerState {
            internal StateBattleStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "infernog_nomal", duration: 6000, script: "$02000410_BF__PopUpCinema__3$", voice: @"ko/Monster/60000725");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateBattleStart05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart05 : TriggerState {
            internal StateBattleStart05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "tristan_normal", duration: 6500, script: "$02000410_BF__PopUpCinema__4$", voice: @"ko/Npc/00002172");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WorldInvasionScene") == 2) {
                    return new State두번째팝업영상출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째팝업영상출력 : TriggerState {
            internal State두번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene2.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__PopUpCinema__5$", voice: @"ko/Npc/00002178");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State두번째팝업영상출력02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째팝업영상출력02 : TriggerState {
            internal State두번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__PopUpCinema__6$", voice: @"ko/Npc/00002173");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WorldInvasionScene") == 3) {
                    return new State세번째팝업영상출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력 : TriggerState {
            internal State세번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__PopUpCinema__7$", voice: @"ko/Npc/00002179");
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene3.usm", duration: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State세번째팝업영상출력02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력02 : TriggerState {
            internal State세번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__PopUpCinema__8$", voice: @"ko/Npc/00002174");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State세번째팝업영상출력03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력03 : TriggerState {
            internal State세번째팝업영상출력03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__PopUpCinema__9$", voice: @"ko/Npc/00002180");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State세번째팝업영상출력04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째팝업영상출력04 : TriggerState {
            internal State세번째팝업영상출력04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__PopUpCinema__10$", voice: @"ko/Npc/00002175");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WorldInvasionScene") == 4) {
                    return new State네번째팝업영상출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째팝업영상출력 : TriggerState {
            internal State네번째팝업영상출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Movie, usm: @"Common/WorldInvasionScene4.usm", duration: 0);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000, script: "$02000410_BF__PopUpCinema__11$", voice: @"ko/Npc/00002181");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State네번째팝업영상출력02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째팝업영상출력02 : TriggerState {
            internal State네번째팝업영상출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000, script: "$02000410_BF__PopUpCinema__12$", voice: @"ko/Npc/00002176");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTrigger종료 : TriggerState {
            internal StateTrigger종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
