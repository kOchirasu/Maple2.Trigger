using System;
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900012, key: "SkillBreakMissionReset", value: 0);
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1007")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1006, arg2: 70002151, arg3: "true");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1001")) {
                    context.State = new State보스전_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_시작 : TriggerState {
            internal State보스전_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900012, key: "SkillBreakMissionReset", value: 1);
                context.SideNpcTalk(type: "talk", npcID: 23501011, illust: "Turned_Renduebian_normal",
                    script: "$02020111_BF__MAIN__0$", duration: 5684, voice: @"ko/Npc/00002201");
                context.DungeonResetTime(seconds: 420);
                context.CreateMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5684)) {
                    context.State = new State조건추가(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건추가 : TriggerState {
            internal State조건추가(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})
                    && context.DungeonCheckPlayTime(playSeconds: 420, @operator: "Less")) {
                    context.State = new State보스전_성공(context);
                    return;
                }

                if (context.DungeonCheckPlayTime(playSeconds: 420, @operator: "Equal")) {
                    context.State = new State보스전_타임어택실패(context);
                    return;
                }

                if (context.UserValue(key: "SkillBreakFail", value: 1)) {
                    context.State = new State보스전_스킬브레이크실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_스킬브레이크실패 : TriggerState {
            internal State보스전_스킬브레이크실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonStopTimer();
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State보스전_리셋세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_타임어택실패 : TriggerState {
            internal State보스전_타임어택실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스전_타임어택실패세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_리셋세팅 : TriggerState {
            internal State보스전_리셋세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900012, key: "SkillBreakMissionReset", value: 0);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 9, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 12, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.DestroyMonster(arg1: new int[] {-1});
                context.MoveUser(arg1: 2020111, arg2: 1, arg3: 1001);
                context.RemoveBuff(arg1: 1006, arg2: 70002151, arg3: "true");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전_타임어택실패세팅 : TriggerState {
            internal State보스전_타임어택실패세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DungeonCloseTimer();
                context.RemoveBuff(arg1: 1006, arg2: 70002151, arg3: "true");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State보스전_성공 : TriggerState {
            internal State보스전_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 23039005);
                context.DungeonSetEndTime();
                context.SideNpcTalk(type: "talk", npcID: 23501011, illust: "Turned_Renduebian_normal",
                    script: "$02020111_BF__MAIN__1$", duration: 3176, voice: @"ko/Npc/00002202");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3176)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {-1});
                context.DungeonClear();
                context.SetAchievement(arg2: "trigger", arg3: "ClearBlueLapenta");
                context.RemoveBuff(arg1: 1006, arg2: 70002151, arg3: "true");
                context.SetPortal(arg1: 4, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 9, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 12, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}