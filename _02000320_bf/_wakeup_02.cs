using System;

namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State자는중(context);

        private class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 2001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2002, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2003, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2006, arg2: true, arg3: "Stun_A");
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
                context.SetInteractObject(arg1: new int[] {10000282}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000282}, arg2: 0)) {
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
                context.SetActor(arg1: 2001, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 2002, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 2004, arg2: false, arg3: "Bore_A");
                context.SetActor(arg1: 2005, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 2006, arg2: false, arg3: "Stun_A");
                context.CreateMonster(arg1: new int[] {20004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 20004, arg3: "$02000320_BF__WAKEUP_02__0$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new int[] {20005}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 20005, arg3: "$02000320_BF__WAKEUP_02__1$", arg4: 2, arg5: 1);
                context.CreateMonster(arg1: new int[] {20006}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 20006, arg3: "$02000320_BF__WAKEUP_02__2$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new int[] {20001});
                context.CreateMonster(arg1: new int[] {20002});
                context.CreateMonster(arg1: new int[] {20003});
                context.SetConversation(arg1: 1, arg2: 20003, arg3: "$02000320_BF__WAKEUP_02__3$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 20001, arg3: "$02000320_BF__WAKEUP_02__4$", arg4: 2, arg5: 4);
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
                context.SetConversation(arg1: 1, arg2: 20002, arg3: "$02000320_BF__WAKEUP_02__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 20001, arg3: "$02000320_BF__WAKEUP_02__6$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 20003, arg3: "$02000320_BF__WAKEUP_02__7$", arg4: 2, arg5: 2);
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
                context.SetActor(arg1: 2001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2002, arg2: true, arg3: "Stun_A");
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
                if (context.MonsterDead(arg1: new int[] {20004, 20005, 20006})) {
                    context.State = new State다시잠듬(context);
                    return;
                }

                if (!context.MonsterInCombat(arg1: new int[] {20004, 20005, 20006})) {
                    context.State = new State다시자러감(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointID: 20004);
                context.RemoveBalloonTalk(spawnPointID: 20005);
                context.RemoveBalloonTalk(spawnPointID: 20006);
                context.RemoveBalloonTalk(spawnPointID: 20001);
                context.RemoveBalloonTalk(spawnPointID: 20002);
                context.RemoveBalloonTalk(spawnPointID: 20003);
                context.SetTimer(arg1: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 20004, arg3: "$02000320_BF__WAKEUP_02__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 20005, arg3: "$02000320_BF__WAKEUP_02__9$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 20006, arg3: "$02000320_BF__WAKEUP_02__10$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(arg1: new int[] {20001, 20002, 20003, 20004, 20005, 20006});
                context.SetTimer(arg1: "15", arg2: 7);
                context.SetActor(arg1: 2004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 2005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 22006, arg2: true, arg3: "Stun_A");
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