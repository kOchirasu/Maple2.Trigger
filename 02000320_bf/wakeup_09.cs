namespace Maple2.Trigger._02000320_bf {
    public static class _wakeup_09 {
        public class State자는중 : TriggerState {
            internal State자는중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 9001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9003, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: true, arg3: "Stun_A");
            }

            public override TriggerState Execute() {
                return new State도둑듬(context);
            }

            public override void OnExit() { }
        }

        private class State도둑듬 : TriggerState {
            internal State도둑듬(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000353}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000353}, arg2: 0)) {
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
                context.SetActor(arg1: 9001, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Bore_A");
                context.SetActor(arg1: 9004, arg2: false, arg3: "Bore_A");
                context.SetActor(arg1: 9005, arg2: false, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: false, arg3: "Stun_A");
                context.CreateMonster(arg1: new[] {90004}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90004, script: "$02000320_BF__WAKEUP_09__0$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new[] {90005}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90005, script: "$02000320_BF__WAKEUP_09__1$", arg4: 2, arg5: 1);
                context.CreateMonster(arg1: new[] {90006}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 90006, script: "$02000320_BF__WAKEUP_09__2$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new[] {90001});
                context.CreateMonster(arg1: new[] {90002});
                context.CreateMonster(arg1: new[] {90003});
                context.SetConversation(arg1: 1, arg2: 90003, script: "$02000320_BF__WAKEUP_09__3$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 90001, script: "$02000320_BF__WAKEUP_09__4$", arg4: 2, arg5: 4);
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
                context.SetConversation(arg1: 1, arg2: 90002, script: "$02000320_BF__WAKEUP_09__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 90001, script: "$02000320_BF__WAKEUP_09__6$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 90003, script: "$02000320_BF__WAKEUP_09__7$", arg4: 2, arg5: 2);
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
                context.SetActor(arg1: 9001, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9002, arg2: true, arg3: "Stun_A");
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
                if (context.MonsterDead(arg1: new[] {90004, 90005, 90006})) {
                    return new State다시잠듬(context);
                }

                if (!context.MonsterInCombat(arg1: new[] {90004, 90005, 90006})) {
                    return new State다시자러감(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다시자러감 : TriggerState {
            internal State다시자러감(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBalloonTalk(spawnPointId: 90004);
                context.RemoveBalloonTalk(spawnPointId: 90005);
                context.RemoveBalloonTalk(spawnPointId: 90006);
                context.RemoveBalloonTalk(spawnPointId: 90001);
                context.RemoveBalloonTalk(spawnPointId: 90002);
                context.RemoveBalloonTalk(spawnPointId: 90003);
                context.SetTimer(id: "14", arg2: 4);
                context.SetConversation(arg1: 1, arg2: 90004, script: "$02000320_BF__WAKEUP_09__8$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 90005, script: "$02000320_BF__WAKEUP_09__9$", arg4: 2, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 90006, script: "$02000320_BF__WAKEUP_09__10$", arg4: 2, arg5: 2);
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
                context.DestroyMonster(arg1: new[] {90001, 90002, 90003, 90004, 90005, 90006});
                context.SetTimer(id: "15", arg2: 7);
                context.SetActor(arg1: 9004, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9005, arg2: true, arg3: "Stun_A");
                context.SetActor(arg1: 9006, arg2: true, arg3: "Stun_A");
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