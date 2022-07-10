namespace Maple2.Trigger._02000253_bf {
    public static class _mob {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002527);
                context.HideGuideSummary(entityId: 20002528);
                context.HideGuideSummary(entityId: 20002529);
                context.HideGuideSummary(entityId: 20002530);
                context.HideGuideSummary(entityId: 20002531);
                context.HideGuideSummary(entityId: 20002532);
                context.SetLadder(triggerId: 1701, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1702, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1703, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1704, visible: false, animationEffect: false, animationDelay: 0);
                context.SetInteractObject(interactIds: new []{13000005}, state: 2);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 906) == 1) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 8);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State몹1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹1 : TriggerState {
            internal State몹1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002527, textId: 20002527);
                context.SetTimer(timerId: "1", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State몹2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001050}, arg2: 0)) {
                    return new State몹2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001051}, arg2: 0)) {
                    return new State몹2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001052}, arg2: 0)) {
                    return new State몹2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10001053}, arg2: 0)) {
                    return new State몹2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹2 : TriggerState {
            internal State몹2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002528, textId: 20002528);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4002, 4004, 4008}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4002, 4004, 4006, 4008})) {
                    return new State몹3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹3 : TriggerState {
            internal State몹3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002529, textId: 20002529);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4003, 4007}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4001, 4003, 4005, 4007})) {
                    return new State몹4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹4 : TriggerState {
            internal State몹4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002530, textId: 20002530);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4002, 4003, 4004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4001, 4002, 4003, 4005, 4006})) {
                    return new State몹5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹5 : TriggerState {
            internal State몹5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002531, textId: 20002531);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4005, 4006, 4007, 4008}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4003, 4004, 4005, 4006, 4007, 4008})) {
                    return new State몹6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹6 : TriggerState {
            internal State몹6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002532, textId: 20002532);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4002, 4003, 4004, 4005}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4001, 4002, 4003, 4004, 4005, 4006})) {
                    return new State몹10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹7 : TriggerState {
            internal State몹7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002533, textId: 20002533);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State몹8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹8 : TriggerState {
            internal State몹8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State몹9(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹9 : TriggerState {
            internal State몹9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State몹10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몹10 : TriggerState {
            internal State몹10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002533, textId: 20002533);
                context.SetTimer(timerId: "1", seconds: 20);
                context.CreateMonster(spawnIds: new []{4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016})) {
                    return new State열려(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열려 : TriggerState {
            internal State열려(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002524, textId: 20002524);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetLadder(triggerId: 1701, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1702, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1703, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1704, visible: true, animationEffect: true, animationDelay: 2);
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002524);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
