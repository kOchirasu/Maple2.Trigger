using System;

namespace Maple2.Trigger._02020146_bf {
    public static class _bossspawn {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State기본셋팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본셋팅 : TriggerState {
            internal State기본셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 601, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new State보스등장이벤트대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장이벤트대기 : TriggerState {
            internal State보스등장이벤트대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {99}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출대기 : TriggerState {
            internal State연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 23000113, illust: "Ishura_Dark_Idle",
                    script: "$02020120_BF__BOSSSPAWN__0$", duration: 4000, voice: @"ko/Npc/00002192");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투진행 : TriggerState {
            internal State전투진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 601, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료딜레이 : TriggerState {
            internal State종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg3: "IshuraDungeonClear_Quest");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State마무리연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리연출 : TriggerState {
            internal State마무리연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 23000113, illust: "Ishura_Dark_Idle",
                    script: "$02020120_BF__BOSSSPAWN__2$", duration: 6576, voice: @"ko/Npc/00002194");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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