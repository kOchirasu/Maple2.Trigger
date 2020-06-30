using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._52100051_qd {
    public static class _01_enter {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3002, 3003, 3004, 3006, 3007, 3008}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {3005, 3008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {102, 202});
                context.DestroyMonster(arg1: new int[] {300, 301});
                context.DestroyMonster(arg1: new int[] {900, 901, 910, 911, 912, 913, 920, 921, 922});
                context.CreateMonster(arg1: new int[] {101, 201}, arg2: false);
                context.SetMesh(arg1: new int[] {3202, 3203}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3201}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3300, 3301, 3302, 3303}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10002078}, arg2: 0);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {300, 301}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateNpcTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01 : TriggerState {
            internal StateNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001592, arg3: "$52100051_QD__01_ENTER__0$", arg4: 4);
                context.SetSkip(arg1: "NpcTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateNpcTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk01Skip : TriggerState {
            internal StateNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNpcTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02 : TriggerState {
            internal StateNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 201, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11001597, arg3: "$52100051_QD__01_ENTER__1$", arg4: 5);
                context.SetSkip(arg1: "NpcTalk02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateNpcTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcTalk02Skip : TriggerState {
            internal StateNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNpcMonologue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue01 : TriggerState {
            internal StateNpcMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52100051_QD__01_ENTER__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52100051_QD__01_ENTER__3$", arg4: 2, arg5: 0);
                context.SetUserValue(triggerID: 2, key: "MobSpawn", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNpcChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcChange01 : TriggerState {
            internal StateNpcChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointID: 101);
                context.RemoveBalloonTalk(spawnPointID: 201);
                context.DestroyMonster(arg1: new int[] {101, 201});
                context.CreateMonster(arg1: new int[] {102, 202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateNpcMonologue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcMonologue02 : TriggerState {
            internal StateNpcMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52100051_QD__01_ENTER__4$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52100051_QD__01_ENTER__5$", arg4: 2, arg5: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039501, textID: 20039501, duration: 4000);
                context.SetInteractObject(arg1: new int[] {10002078}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002078}, arg2: 0)) {
                    context.State = new StateGratingOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen01 : TriggerState {
            internal StateGratingOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039502, textID: 20039502, duration: 4000);
                context.SetMesh(arg1: new int[] {3300, 3301, 3302, 3303}, arg2: false, arg3: 500, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateGratingOpen02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen02 : TriggerState {
            internal StateGratingOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {910}, arg2: false);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGratingOpen03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGratingOpen03 : TriggerState {
            internal StateGratingOpen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: false);
                context.CreateMonster(arg1: new int[] {911, 912, 913}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StateMobSpawn_Hallway01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_Hallway01 : TriggerState {
            internal StateMobSpawn_Hallway01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039503, textID: 20039503, duration: 4000);
                context.CreateMonster(arg1: new int[] {920}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9200")) {
                    context.State = new StateMobSpawn_Hallway02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn_Hallway02 : TriggerState {
            internal StateMobSpawn_Hallway02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {921, 922}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9300")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20039504, textID: 20039504, duration: 4000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}