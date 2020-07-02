namespace Maple2.Trigger._02000299_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1010, 1011, 1012, 1013}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetInteractObject(arg1: new[] {10000494, 10000495, 10000496, 10000497, 10000498, 10000499}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new StateClear체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear체크 : TriggerState {
            internal StateClear체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 602, 603, 604, 605, 606, 607, 610}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateClear체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateClear체크2 : TriggerState {
            internal StateClear체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1010})) {
                    return new State타임머신중지(context);
                }

                if (context.MonsterDead(arg1: new[] {1011})) {
                    return new State타임머신중지(context);
                }

                if (context.MonsterDead(arg1: new[] {1012})) {
                    return new State타임머신중지(context);
                }

                if (context.MonsterDead(arg1: new[] {1013})) {
                    return new State타임머신중지(context);
                }

                if (context.WaitTick(waitTick: 100)) {
                    return new State정황설명(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정황설명 : TriggerState {
            internal State정황설명(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002990, textId: 20002990, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State시간반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시간반응대기 : TriggerState {
            internal State시간반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002992, textId: 20002992, duration: 4000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10000494, 10000495}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000494}, arg2: 0)) {
                    return new State미래시간(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000495}, arg2: 0)) {
                    return new State과거시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미래시간 : TriggerState {
            internal State미래시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606, 604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002987, textId: 20002987);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10000495}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000496}, arg2: 0)) {
                    return new State그런거없음(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000497}, arg2: 0)) {
                    return new State미래엘리니아(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000498}, arg2: 0)) {
                    return new State그런거없음(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000499}, arg2: 0)) {
                    return new State미래커닝시티(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20002987);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 0);
            }
        }

        private class State과거시간 : TriggerState {
            internal State과거시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606, 604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002988, textId: 20002988);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetInteractObject(arg1: new[] {10000494}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000496}, arg2: 0)) {
                    return new State과거헤네니스(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000497}, arg2: 0)) {
                    return new State그런거없음(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000498}, arg2: 0)) {
                    return new State과거페리온(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10000499}, arg2: 0)) {
                    return new State그런거없음(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20002988);
                context.SetEffect(arg1: new[] {607}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000496, 10000497, 10000498, 10000499}, arg2: 0);
            }
        }

        private class State미래엘리니아 : TriggerState {
            internal State미래엘리니아(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002989, textId: 20002989);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20002989);
                    return new State미래엘리니아2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미래엘리니아2 : TriggerState {
            internal State미래엘리니아2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000299, arg2: 2, arg3: 104);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {601, 602, 604}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Opened_A");
                context.ShowCountUI(text: "$02000299_BF__MAIN__3$", stage: 1, count: 3);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State미래엘리니아이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미래엘리니아이동 : TriggerState {
            internal State미래엘리니아이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {603, 601}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetEffect(arg1: new[] {605}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000302, arg2: 1, arg3: 104);
                    context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new StateClear체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1010});
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State미래커닝시티 : TriggerState {
            internal State미래커닝시티(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002989, textId: 20002989);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20002989);
                    return new State미래커닝시티2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미래커닝시티2 : TriggerState {
            internal State미래커닝시티2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000299, arg2: 2, arg3: 104);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {601, 602}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Opened_A");
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowCountUI(text: "$02000299_BF__MAIN__5$", stage: 1, count: 3);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State미래커닝시티이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미래커닝시티이동 : TriggerState {
            internal State미래커닝시티이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {603, 601}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetEffect(arg1: new[] {605}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000301, arg2: 1, arg3: 104);
                    context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new StateClear체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1011});
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State과거헤네니스 : TriggerState {
            internal State과거헤네니스(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002989, textId: 20002989);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20002989);
                    return new State과거헤네니스2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거헤네니스2 : TriggerState {
            internal State과거헤네니스2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000299, arg2: 2, arg3: 104);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {601, 602}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Opened_A");
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowCountUI(text: "$02000299_BF__MAIN__7$", stage: 1, count: 3);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State과거헤네니스이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거헤네니스이동 : TriggerState {
            internal State과거헤네니스이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {603, 601}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetEffect(arg1: new[] {605}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000303, arg2: 1, arg3: 104);
                    context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new StateClear체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1012});
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State과거페리온 : TriggerState {
            internal State과거페리온(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002989, textId: 20002989);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20002989);
                    return new State과거페리온2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거페리온2 : TriggerState {
            internal State과거페리온2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000299, arg2: 2, arg3: 104);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {601, 602}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Opened_A");
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowCountUI(text: "$02000299_BF__MAIN__9$", stage: 1, count: 3);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State과거페리온이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State과거페리온이동 : TriggerState {
            internal State과거페리온이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetEffect(arg1: new[] {603, 601}, arg2: true);
                context.SetActor(arg1: 201, arg2: true, arg3: "Closed_A");
                context.SetEffect(arg1: new[] {605}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.MoveUser(arg1: 02000300, arg2: 1, arg3: 104);
                    context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new StateClear체크(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1013});
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State그런거없음 : TriggerState {
            internal State그런거없음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.ShowGuideSummary(entityId: 20002989, textId: 20002989);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.HideGuideSummary(entityId: 20002989);
                    return new State그런거없음2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State그런거없음2 : TriggerState {
            internal State그런거없음2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {606, 607}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
                context.ShowGuideSummary(entityId: 20002994, textId: 20002994);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.HideGuideSummary(entityId: 20002994);
                    return new State방어모드(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방어모드 : TriggerState {
            internal State방어모드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601, 610}, arg2: true);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
                context.ShowGuideSummary(entityId: 20002995, textId: 20002995);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1001, 1002, 1003, 1004})) {
                    context.HideGuideSummary(entityId: 20002995);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_Off");
                    return new State방어모드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State방어모드종료 : TriggerState {
            internal State방어모드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20002996, textId: 20002996);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.HideGuideSummary(entityId: 20002996);
                    return new State시간반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타임머신중지 : TriggerState {
            internal State타임머신중지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new StateBoss방이동준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss방이동준비 : TriggerState {
            internal StateBoss방이동준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEffect(arg1: new[] {603, 610}, arg2: true);
                context.ShowGuideSummary(entityId: 20002997, textId: 20002997);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEffect(arg1: new[] {603, 605, 606, 607}, arg2: true);
                context.SetActor(arg1: 290, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 291, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 292, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 293, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 294, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 295, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 296, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 297, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 298, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 299, arg2: true, arg3: "sf_quest_light_A01_On");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.HideGuideSummary(entityId: 20002997);
                    return new StateBoss방이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss방이동 : TriggerState {
            internal StateBoss방이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.ShowCountUI(text: "$02000299_BF__MAIN__15$", stage: 1, count: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.MoveUser(arg1: 02000304, arg2: 1);
                    return new State반복체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반복체크 : TriggerState {
            internal State반복체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.ShowGuideSummary(entityId: 20002997, textId: 20002997);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.HideGuideSummary(entityId: 20002997);
                    return new StateBoss방이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}