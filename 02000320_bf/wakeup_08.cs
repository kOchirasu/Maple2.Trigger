namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_08 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8002, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8003, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8006, arg2: true, arg3: "Stun_A");
            }

            public override TriggerState Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000352}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000352}, arg2: 0)) {
                    return new State깨어남1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남1 : TriggerState {
            internal State깨어남1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 8);
                context.SetActor(arg1: 8001, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 8002, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Bore_A");
                context.SetActor(arg1: 8005, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 8006, arg2: false, arg3: "Stun_A");
                context.CreateMonster(arg1: new[] {80004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 80004, script: "$02000320_BF__WAKEUP_08__0$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new[] {80005}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 80005, script: "$02000320_BF__WAKEUP_08__1$", arg4: 2, arg5: 1);
                context.CreateMonster(arg1: new[] {80006}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 80006, script: "$02000320_BF__WAKEUP_08__2$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new[] {80001});
                context.CreateMonster(arg1: new[] {80002});
                context.CreateMonster(arg1: new[] {80003});
                context.SetConversation(arg1: 1, arg2: 80003, script: "$02000320_BF__WAKEUP_08__3$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 80001, script: "$02000320_BF__WAKEUP_08__4$", arg4: 2, arg5: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new State깨어남2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남2 : TriggerState {
            internal State깨어남2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "11", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 80002, script: "$02000320_BF__WAKEUP_08__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 80001, script: "$02000320_BF__WAKEUP_08__6$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 80003, script: "$02000320_BF__WAKEUP_08__7$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "11")) {
                    return new State깨어남3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남3 : TriggerState {
            internal State깨어남3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "12", arg2: 1);
                context.SetActor(arg1: 8001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8002, arg2: true, arg3: "Stun_A");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "12")) {
                    return new State깨어남4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State깨어남4 : TriggerState {
            internal State깨어남4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {80004, 80005, 80006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {80004, 80005, 80006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 80004);
                context.RemoveBalloonTalk(spawnPointId: 80005);
                context.RemoveBalloonTalk(spawnPointId: 80006);
                context.RemoveBalloonTalk(spawnPointId: 80001);
                context.RemoveBalloonTalk(spawnPointId: 80002);
                context.RemoveBalloonTalk(spawnPointId: 80003);
                context.SetTimer(id: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 80004, script: "$02000320_BF__WAKEUP_08__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 80005, script: "$02000320_BF__WAKEUP_08__9$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 80006, script: "$02000320_BF__WAKEUP_08__10$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "14")) {
                    return new State다시잠듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시잠듬 : TriggerState {
            internal State다시잠듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {80001, 80002, 80003, 80004, 80005, 80006});
                context.SetTimer(id: "15", arg2: 7);
                context.SetActor(arg1: 8004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 8006, arg2: true, arg3: "Stun_A");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "15")) {
                    return new State도둑듬(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}