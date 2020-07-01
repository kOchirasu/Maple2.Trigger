namespace Maple2.Trigger._52100002_qd {
    public static class _summon {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SummonSister") == 1) {
                    context.State = new State룸체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State소환(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new State퀘스트소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", msg: "$02000392_BF__SUMMON__0$",
                    align: "left", duration: 2000);
                context.SetSkip(arg1: "죽음대기");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraReset(interpolationTime: 1.0f);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.State = new State죽음대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트소환 : TriggerState {
            internal State퀘스트소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 300, arg2: true);
                context.CreateMonster(arg1: new[] {2102}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", msg: "$02000392_BF__SUMMON__0$",
                    align: "left", duration: 2000);
                context.SetSkip(arg1: "퀘스트죽음대기");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.CameraReset(interpolationTime: 1.0f);
                    context.SetProductionUI(arg1: 0);
                    context.SetProductionUI(arg1: 2);
                    context.State = new State퀘스트죽음대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트죽음대기 : TriggerState {
            internal State퀘스트죽음대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2101})) {
                    context.State = new State퀘스트셀린사망(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2102})) {
                    context.State = new State퀘스트피리스사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트셀린사망 : TriggerState {
            internal State퀘스트셀린사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2102, arg3: "$02000392_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2102}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트피리스사망 : TriggerState {
            internal State퀘스트피리스사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2101, arg3: "$02000392_BF__SUMMON__2$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2101}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State죽음대기 : TriggerState {
            internal State죽음대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State셀린사망(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.State = new State피리스사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State셀린사망 : TriggerState {
            internal State셀린사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2002, arg3: "$02000392_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2002}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피리스사망 : TriggerState {
            internal State피리스사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "BigSisterFirst");
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000392_BF__SUMMON__2$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2001}, arg2: 40442003, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}