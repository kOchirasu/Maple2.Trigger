namespace Maple2.Trigger._02000429_bf {
    public static class _event01 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    context.State = new State전투시작잠시대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작잠시대기 : TriggerState {
            internal State전투시작잠시대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State전투시작_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작_인페르녹전함 : TriggerState {
            internal State전투시작_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041002, textId: 20041002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State첫번째페이즈_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041002);
            }
        }

        private class State첫번째페이즈_인페르녹전함 : TriggerState {
            internal State첫번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "AirshipBalrogCrimsonBroken") == 1) {
                    context.State = new State인페르녹전함파괴연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴연출 : TriggerState {
            internal State인페르녹전함파괴연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041003, textId: 20041003);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 5000,
                    script: "$02000410_BF__Event01__0$", voice: @"ko/Npc/00002167");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹전함파괴연출2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴연출2 : TriggerState {
            internal State인페르녹전함파괴연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__Event01__1$", voice: @"ko/Npc/00002158");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State두번째페이즈_인페르녹전함(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041003);
            }
        }

        private class State두번째페이즈_인페르녹전함 : TriggerState {
            internal State두번째페이즈_인페르녹전함(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "AirshipBalrogCrimsonFlameBroken") == 1) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴_인페르녹등장연출 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041004, textId: 20041004);
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_normal", duration: 4500,
                    script: "$02000410_BF__Event01__2$", voice: @"ko/Npc/00002168");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041004);
            }
        }

        private class State인페르녹전함파괴_인페르녹등장연출2 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 3800,
                    script: "$02000410_BF__Event01__3$", voice: @"ko/Npc/00002169");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3800)) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴_인페르녹등장연출3 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_closeEye", duration: 5200,
                    script: "$02000410_BF__Event01__4$", voice: @"ko/Npc/00002159");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5200)) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴_인페르녹등장연출4 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02000410_BF__Event01__8$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴_인페르녹등장연출5 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Neirin_surprise", duration: 5000,
                    script: "$02000410_BF__Event01__9$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State인페르녹전함파괴_인페르녹등장연출6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인페르녹전함파괴_인페르녹등장연출6 : TriggerState {
            internal State인페르녹전함파괴_인페르녹등장연출6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11003536, illust: "Bliche_nomal", duration: 5000,
                    script: "$02000410_BF__Event01__7$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State세번째페이즈_인페르녹등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째페이즈_인페르녹등장 : TriggerState {
            internal State세번째페이즈_인페르녹등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "BalrogMagicBursterBattlePhase") == 1) {
                    // context.State = new State성공이벤트실행(context);
                    return;
                }

                if (context.GetUserValue(key: "BalrogMagicBursterBattlePhase") == 1) {
                    // context.State = new State실패이벤트실행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}