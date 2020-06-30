using System;

namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_09 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State자는중(context);

        private class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9003, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: true, arg3: "Stun_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State도둑듬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000353}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000353}, arg2: 0)) {
                    context.State = new State깨어남1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어남1 : TriggerState {
            internal State깨어남1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 8);
                context.SetActor(arg1: 9001, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 9004, arg2: false, arg3: "Bore_A");
                context.SetActor(arg1: 9005, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: false, arg3: "Stun_A");
                context.CreateMonster(arg1: new int[] {90004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90004, arg3: "$02000320_BF__WAKEUP_09__0$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new int[] {90005}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90005, arg3: "$02000320_BF__WAKEUP_09__1$", arg4: 2, arg5: 1);
                context.CreateMonster(arg1: new int[] {90006}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90006, arg3: "$02000320_BF__WAKEUP_09__2$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new int[] {90001});
                context.CreateMonster(arg1: new int[] {90002});
                context.CreateMonster(arg1: new int[] {90003});
                context.SetConversation(arg1: 1, arg2: 90003, arg3: "$02000320_BF__WAKEUP_09__3$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 90001, arg3: "$02000320_BF__WAKEUP_09__4$", arg4: 2, arg5: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State깨어남2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어남2 : TriggerState {
            internal State깨어남2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 90002, arg3: "$02000320_BF__WAKEUP_09__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 90001, arg3: "$02000320_BF__WAKEUP_09__6$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 90003, arg3: "$02000320_BF__WAKEUP_09__7$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State깨어남3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어남3 : TriggerState {
            internal State깨어남3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "12", arg2: 1);
                context.SetActor(arg1: 9001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Stun_A");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    context.State = new State깨어남4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어남4 : TriggerState {
            internal State깨어남4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {90004, 90005, 90006})) {
                    context.State = new State다시잠듬(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {90004, 90005, 90006})) {
                    context.State = new State다시자러감(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointID: 90004);
                context.RemoveBalloonTalk(spawnPointID: 90005);
                context.RemoveBalloonTalk(spawnPointID: 90006);
                context.RemoveBalloonTalk(spawnPointID: 90001);
                context.RemoveBalloonTalk(spawnPointID: 90002);
                context.RemoveBalloonTalk(spawnPointID: 90003);
                context.SetTimer(arg1: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 90004, arg3: "$02000320_BF__WAKEUP_09__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 90005, arg3: "$02000320_BF__WAKEUP_09__9$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 90006, arg3: "$02000320_BF__WAKEUP_09__10$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State다시잠듬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다시잠듬 : TriggerState {
            internal State다시잠듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {90001, 90002, 90003, 90004, 90005, 90006});
                context.SetTimer(arg1: "15", arg2: 7);
                context.SetActor(arg1: 9004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: true, arg3: "Stun_A");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    context.State = new State도둑듬(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}